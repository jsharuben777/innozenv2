using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Test_web_1.Models
{
    public partial class Feedback
    {
       
        public int Feedback_Id { get; set; }
        public string? Full_Name { get; set; }
        public string? Comment { get; set; }
        public string? Department { get; set; }
       
    }
}