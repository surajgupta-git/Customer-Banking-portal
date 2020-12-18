using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Class1
    {


        private string _customername;

        public string Customername
        {
            get => _customername;
            set => _customername = value;
        }

        public bool Customervalidation(string customername)
        {
            if (customername.Length == 0)
                return false;
            else
                return true;
        }


    }
    }
  