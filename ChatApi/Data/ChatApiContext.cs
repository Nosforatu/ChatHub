using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatApi.Models;

namespace ChatApi.Data
{
    public class ChatApiContext : DbContext
    {
        public ChatApiContext (DbContextOptions<ChatApiContext> options)
            : base(options)
        {
        }

        public DbSet<ChatApi.Models.Messages> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
