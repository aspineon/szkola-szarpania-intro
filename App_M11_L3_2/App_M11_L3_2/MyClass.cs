using System;
using System.Collections.Generic;
using System.Text;

namespace App_M11_L3_2
{
    class MyClass
    {
        private int _field;

        public int Field
        {
            get
            {
                return _field * 2;
            }
            set
            {
                _field = value / 2;
            }
        }
    }
}
