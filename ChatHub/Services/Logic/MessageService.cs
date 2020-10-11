using ChatHub.Models;
using ChatHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Services.Logic
{
    public class MessageService : IMessagesService
    {
        public List<UserMessage> GetMessages()
        {
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
