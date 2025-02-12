// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.OpenAI
{
    public partial class ChatFinishDetails
    {
        internal static ChatFinishDetails DeserializeChatFinishDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "stop": return StopFinishDetails.DeserializeStopFinishDetails(element);
                    case "max_tokens": return MaxTokensFinishDetails.DeserializeMaxTokensFinishDetails(element);
                }
            }
            return UnknownChatFinishDetails.DeserializeUnknownChatFinishDetails(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatFinishDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatFinishDetails(document.RootElement);
        }
    }
}
