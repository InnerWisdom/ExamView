using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
  public class PassViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string name { get; set; }

        [DisplayName("Номер рейса")]
        public int reisId { get; set; }

        [DisplayName("Дата покупки")]
        public DateTime date { get; set; }

        [DisplayName("Номер места")]
        public decimal numPlace { get; set; }

        [DisplayName("Гражданство")]
        public string grazdanstvo { get; set; }
    }
}
    

