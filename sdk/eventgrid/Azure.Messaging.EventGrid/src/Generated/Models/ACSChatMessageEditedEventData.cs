// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Communication.ChatMessageEdited event. </summary>
    public partial class ACSChatMessageEditedEventData : ACSChatMessageEventBaseProperties
    {
        /// <summary> Initializes a new instance of ACSChatMessageEditedEventData. </summary>
        internal ACSChatMessageEditedEventData()
        {
        }

        /// <summary> Initializes a new instance of ACSChatMessageEditedEventData. </summary>
        /// <param name="recipientId"> The MRI of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="messageId"> The chat message id. </param>
        /// <param name="senderId"> The MRI of the sender. </param>
        /// <param name="senderDisplayName"> The display name of the sender. </param>
        /// <param name="composeTime"> The original compose time of the message. </param>
        /// <param name="type"> The type of the message. </param>
        /// <param name="version"> The version of the message. </param>
        /// <param name="messageBody"> The body of the chat message. </param>
        /// <param name="editTime"> The time at which the message was edited. </param>
        internal ACSChatMessageEditedEventData(string recipientId, string transactionId, string threadId, string messageId, string senderId, string senderDisplayName, DateTimeOffset? composeTime, string type, long? version, string messageBody, DateTimeOffset? editTime) : base(recipientId, transactionId, threadId, messageId, senderId, senderDisplayName, composeTime, type, version)
        {
            MessageBody = messageBody;
            EditTime = editTime;
        }

        /// <summary> The body of the chat message. </summary>
        public string MessageBody { get; }
        /// <summary> The time at which the message was edited. </summary>
        public DateTimeOffset? EditTime { get; }
    }
}
