﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApi.Models
{
    public class Messages
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public string TimeStamp { get; set; }
    }
}
