using ChatHub.Models;
using ChatHub.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            var temp = JsonConvert.DeserializeObject<List<UserMessage>>(await response.Content.ReadAsStringAsync());


            return new List<UserMessage>()
            {
                new UserMessage()
                {
                    Message = "Message One",
                    TimeStamp = DateTime.Now,
                    Type = UserMessage.MessgageType.Server
                },
                new UserMessage()
                {
                    Message = "Message Two",
                    TimeStamp = DateTime.Now,
                    Type = UserMessage.MessgageType.Othere, 
                    UserName = "John"
                },
                new UserMessage()
                {
                    Message = "Message three",
                    TimeStamp = DateTime.Now,
                    Type = UserMessage.MessgageType.User, 
                    UserName = "Jane"
                }
            };
        }

        public bool SentMessage(UserMessage message)
        {
            return true;
        }
    }
}
