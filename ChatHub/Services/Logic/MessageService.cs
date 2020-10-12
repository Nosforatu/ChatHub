using ChatHub.Models;
using ChatHub.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChatHub.Services.Logic
{
    public class MessageService : IMessagesService
    {
        private HttpClient httpClient;

        public MessageService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<UserMessage>> GetMessages()
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:44311/api/messages");
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UserMessage>>(responseString);
        }

        public async Task<bool> SendMessage(UserMessage message)
        {
            var messageString = JsonConvert.SerializeObject(message);
            var contentData = new StringContent(messageString, Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync("https://localhost:44311/api/messages", contentData);
            return (result.StatusCode == System.Net.HttpStatusCode.Created);
        }
    }
}
