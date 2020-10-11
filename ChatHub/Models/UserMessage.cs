using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Models
{
    public class UserMessage
    {
        public enum MessgageType
        {
            Server, User, Othere
        }

        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public MessgageType Type { get; set; }
    }
}
