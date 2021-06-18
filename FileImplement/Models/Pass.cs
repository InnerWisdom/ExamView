using System;
using System.Collections.Generic;
using System.Text;

namespace FileImplement.Models
{
    [Serializable]
    public class Pass
    {
        public int Id { get; set; }
        public int reisId { get; set; } 
        public string name { get; set; }
        public decimal numPlace { get; set; }
        public DateTime date { get; set; }
        public string grazdanstvo { get; set; }
        //public virtual Reis reis { get; set; }
    }
}