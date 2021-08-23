using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Meat: Food
    {
        public Meat(int amount) 
        {
            Type = "meat";
            Amount = amount;
        }
    }
}
