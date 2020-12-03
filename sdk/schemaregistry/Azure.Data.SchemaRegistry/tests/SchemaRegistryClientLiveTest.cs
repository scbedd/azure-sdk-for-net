// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Data.SchemaRegistry.Tests
{
    public class SchemaRegistryClientLiveTest : RecordedTestBase<SchemaRegistryClientTestEnvironment>
    {
        public SchemaRegistryClientLiveTest(bool isAsync) : base(isAsync, GetMode())
        {
            TestDiagnostics = false;
        }

        private static RecordedTestMode GetMode()
        {
            // !! TODO: Variable recording not handled remotely yet. It's problematic
            // because the tests expect to read these straight away.
            var envFile = @"C:\temp\env-schema\.env";

            foreach (var line in File.ReadAllLines(envFile))
            {
                var trimmed = line.Trim();
                if (trimmed.Length == 0 || trimmed[0] == '#')
                {
                    continue;
                }

                var parts = trimmed.Split(new[] { '=' }, 2);
                var key = parts[0];
                var value = parts[1];
                Environment.SetEnvironmentVariable(key, value);
            }

            return RecordedTestUtilities.GetModeFromEnvironment();
        }

        private SchemaRegistryClient CreateClient() =>
            InstrumentClient(new SchemaRegistryClient(
                TestEnvironment.SchemaRegistryEndpoint,
                TestEnvironment.Credential,
                InstrumentClientOptions(new SchemaRegistryClientOptions())
            ));

        private const string SchemaContent = "{\"type\" : \"record\",\"namespace\" : \"TestSchema\",\"name\" : \"Employee\",\"fields\" : [{ \"name\" : \"Name\" , \"type\" : \"string\" },{ \"name\" : \"Age\", \"type\" : \"int\" }]}";

        [Test]
        public async Task CanRegisterSchema()
        {
            var client = CreateClient();
            var schemaName = "test1";
            var groupName = TestEnvironment.SchemaRegistryGroup;
            var schemaType = SerializationType.Avro;

            var schemaProperties = await client.RegisterSchemaAsync(groupName, schemaName, schemaType, SchemaContent);
            Assert.IsNotNull(schemaProperties.Value);
            Assert.IsNotNull(schemaProperties.Value.Id);
            Assert.IsTrue(Guid.TryParse(schemaProperties.Value.Id, out Guid _));
            Assert.AreEqual(SchemaContent, schemaProperties.Value.Content);
        }

        [Test]
        public async Task CanGetSchemaId()
        {
            var client = CreateClient();
            var schemaName = "test1";
            var groupName = TestEnvironment.SchemaRegistryGroup;
            var schemaType = SerializationType.Avro;

            await client.RegisterSchemaAsync(groupName, schemaName, schemaType, SchemaContent);
            var schemaProperties = await client.GetSchemaIdAsync(groupName, schemaName, schemaType, SchemaContent);
            Assert.IsNotNull(schemaProperties.Value);
            Assert.IsNotNull(schemaProperties.Value.Id);
            Assert.IsTrue(Guid.TryParse(schemaProperties.Value.Id, out Guid _));
            Assert.AreEqual(SchemaContent, schemaProperties.Value.Content);
        }

        [Test]
        public async Task CanGetSchema()
        {
            var client = CreateClient();
            var schemaName = "test1";
            var groupName = TestEnvironment.SchemaRegistryGroup;
            var schemaType = SerializationType.Avro;

            var registerProperties = await client.RegisterSchemaAsync(groupName, schemaName, schemaType, SchemaContent);
            Assert.IsNotNull(registerProperties.Value.Id);
            Assert.IsTrue(Guid.TryParse(registerProperties.Value.Id, out Guid _));

            var schemaProperties = await client.GetSchemaAsync(registerProperties.Value.Id);
            Assert.IsNotNull(schemaProperties.Value);
            Assert.IsNotNull(schemaProperties.Value.Id);
            Assert.IsTrue(Guid.TryParse(schemaProperties.Value.Id, out Guid _));
            Assert.AreEqual(Regex.Replace(SchemaContent, @"\s+", string.Empty), schemaProperties.Value.Content);
        }
    }
}
