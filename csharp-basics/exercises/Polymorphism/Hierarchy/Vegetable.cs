using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Vegetable: Food
    {
        public Vegetable(int Amount) 
        {
            type = "vegetable";
            amount = Amount;
        }
    }
}
