using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_web_1.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? Admin_Username { get; set; }
        public string? Admin_Password { get; set; }
        public string? Admin_Department { get; set; }
      
    }
}
