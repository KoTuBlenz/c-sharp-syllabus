using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Vegetable: Food
    {
        public Vegetable(int amount) 
        {
            Type = "vegetable";
            Amount = amount;
        }
    }
}
