// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyProperty. </summary>
    internal partial class AnomalyProperty
    {
        /// <summary> Initializes a new instance of AnomalyProperty. </summary>
        /// <param name="anomalySeverity"> anomaly severity. </param>
        internal AnomalyProperty(AnomalySeverity anomalySeverity)
        {
            AnomalySeverity = anomalySeverity;
        }

        /// <summary> Initializes a new instance of AnomalyProperty. </summary>
        /// <param name="anomalySeverity"> anomaly severity. </param>
        /// <param name="anomalyStatus">
        /// anomaly status
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </param>
        internal AnomalyProperty(AnomalySeverity anomalySeverity, AnomalyStatus? anomalyStatus)
        {
            AnomalySeverity = anomalySeverity;
            AnomalyStatus = anomalyStatus;
        }

        /// <summary> anomaly severity. </summary>
        public AnomalySeverity AnomalySeverity { get; }
        /// <summary>
        /// anomaly status
        /// 
        /// 
        /// 
        /// only return for alerting anomaly result.
        /// </summary>
        public AnomalyStatus? AnomalyStatus { get; }
    }
}
