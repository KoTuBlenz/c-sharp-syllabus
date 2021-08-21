using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Meat: Food
    {
        public Meat(int Amount) 
        {
            type = "meat";
            amount = Amount;
        }
    }
}
