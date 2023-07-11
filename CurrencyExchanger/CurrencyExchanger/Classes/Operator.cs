using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger.Classes
{
    public class Operator
    {
        private static Operator instance;

        private Operator() { }

        public static Operator GetInstance()
        {
            return instance ?? (instance = new Operator());
        }

        public int operatorId { get; set; }
        public string operatorName { get; set; }
        public string operatorPassword { get; set; }
        public string operatorType { get; set; }
    }
}
