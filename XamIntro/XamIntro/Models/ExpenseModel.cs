using System;
using System.Collections.Generic;
using System.Text;

namespace XamIntro.Models
{
    public class ExpenseModel
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }
        public string Receipt { get; set; }
    }
}
