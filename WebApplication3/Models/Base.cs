using System;
using System.ComponentModel.DataAnnotations;

namespace EFDataApp.Models
{
    public class Base
    { 
        
        public int Id { get; set; }
        
        public string City_out { get; set; }
        
        public string Adress_out { get; set; }
        
        public string City_in { get; set; }
        
        public string Adress_in { get; set; }
        
        public int Weight { get; set; }
        
        public DateTime Date { get; set; }
    }
}