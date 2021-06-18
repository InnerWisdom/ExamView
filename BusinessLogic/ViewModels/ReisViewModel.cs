using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class ReisViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Дата вылета")]
        public DateTime date { get; set; }

        [DisplayName("Авиакомпания")]
        public string company { get; set; }
    }
}
