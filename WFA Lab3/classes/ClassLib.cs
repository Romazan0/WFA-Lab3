using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Phone
    {
        public string Model;
        public string Diagonal;
        public int Cores;
        public string Platform;
        public int SimQuantity;
        public bool HasAI;
        public bool HasTypeC;

        public string Has4Cores()
        {
            if (Cores == 4)
            {
                return "Телефон має 4 ядра";
            }
            return "Телефон не має 4 ядер";
        }
        public string GetPhone4Cores
        {
            get
            {
                return Has4Cores();
            }
        }
    }
}
