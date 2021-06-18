using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
   public class PassBindingModel
    {
        public int? Id { get; set; }
        public int ReisId { get; set; }
        public string name { get; set; }
        public decimal numberPlace { get; set; }
        public DateTime date { get; set; }
        public string grazdanstvo { get; set; }
    }
}
