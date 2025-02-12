// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of the available Azure OpenAI enhancement configurations. </summary>
    public partial class AzureChatEnhancementConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancementConfiguration"/>. </summary>
        public AzureChatEnhancementConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancementConfiguration"/>. </summary>
        /// <param name="grounding"> A representation of the available options for the Azure OpenAI grounding enhancement. </param>
        /// <param name="ocr"> A representation of the available options for the Azure OpenAI optical character recognition (OCR) enhancement. </param>
        internal AzureChatEnhancementConfiguration(AzureChatGroundingEnhancementConfiguration grounding, AzureChatOCREnhancementConfiguration ocr)
        {
            Grounding = grounding;
            Ocr = ocr;
        }

        /// <summary> A representation of the available options for the Azure OpenAI grounding enhancement. </summary>
        public AzureChatGroundingEnhancementConfiguration Grounding { get; set; }
        /// <summary> A representation of the available options for the Azure OpenAI optical character recognition (OCR) enhancement. </summary>
        public AzureChatOCREnhancementConfiguration Ocr { get; set; }
    }
}
