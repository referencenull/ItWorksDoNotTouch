namespace bestapp;

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Azure.AI.OpenAI;
using Azure;

    public class OpenAIAPi
    {
        public static async Task OwnCopilot()
        {
            var apiKey = "4f744df7cfc3470784bd17a1fd0ef4b9";
            var endpoint = "https://jukarvon-ai-aiservices-1468176045.openai.azure.com/";
            string deploymentName = "gpt-4";

            OpenAIClient client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            ChatCompletionsOptions chatCompletionsOptions = new ChatCompletionsOptions()
            {
                Messages = 
                {
                    new ChatMessage(ChatRole.System, "You are a helpful AI bot."), 
                    new ChatMessage(ChatRole.User, "Mikä on paras ajoasento")
                },
                DeploymentName = deploymentName
            };

            // Send request to Azure OpenAI model
            ChatCompletions chatCompletionsResponse = client.GetChatCompletions( 
                chatCompletionsOptions);

            ChatMessage completion = chatCompletionsResponse.Choices[0].Message;
            Console.WriteLine($"Chatbot: {completion.Content}");
            
        }
    }