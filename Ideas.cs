using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_web_1.Models
{
    public partial class Ideas
    {
        [Key]
        public int Ideas_Id { get; set; }
        public string? Full_Name { get; set; }
        public string? Manager_Name { get; set; }
        public string? Problem { get; set; }
        public string? Cause { get; set; }
        public string? Solution { get; set; }
       
    }
}
