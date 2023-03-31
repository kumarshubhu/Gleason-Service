using System;
using System.ComponentModel.DataAnnotations;

namespace Gleason_UserInterface_Service.Models
{
    public class User
    {
        [Key]
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
