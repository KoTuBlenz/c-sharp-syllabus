using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        string _dogName;
        string _dogSex;
        string _dogMother;
        string _dogFather;
        public Dog(string name, string sex, string mother, string father)
        {
            _dogName = name;
            _dogSex = sex;
            _dogMother = mother;
            _dogFather = father;
        }
        public string FathersName()
        {
            if (_dogFather == null)
            {
                return "Unknown";
            }
            else
            {
                return _dogFather;
            }
        }
        public bool HasSameMotherAs(Dog otherDog)
        {
            if(_dogMother == otherDog._dogMother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
