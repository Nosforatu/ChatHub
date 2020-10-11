using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Models
{
    public class LoginModel
    {
        [StringLength(50, ErrorMessage = "Please fill in your Username")]
        public string UserName { get; set; }

        [StringLength(500, ErrorMessage = "Please fill in your Password")]
        public string Password { get; set; }

        [StringLength(50, ErrorMessage = "Please fill in your Name")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }
    }
}
