using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Test_web_1.Models;

namespace Test_web_1.Models
{
    public partial class Registration
    {
        [Key]
        public int UserId { get; set; }
        public string? Username { get; set; } 
        public string? Password { get; set; } 
        public string? FullName { get; set; }
        public int? BadgeNum { get; set; } 
        public string? Department { get; set; } 
        public string? ManagerName { get; set; } 
        public string? Email { get; set; } 
    }


    
    
    }

