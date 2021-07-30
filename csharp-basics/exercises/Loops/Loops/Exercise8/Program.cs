using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int pyramidSize = 7;
            const int pyramidStepSize = 4;  //Step size between pyramids layers. Step size 1 is really smooth pyramid. Cant be 0
            const int pyramidLenght = (pyramidSize - 1) * pyramidStepSize;
            char pyramidSideL = '/';        // Charecter with whom the left side of pyramid will be filled
            char pyramidSideR = '\\';       // Charecter with whom the right side of pyramid will be filled
            char pyramidFill = '*';         // Charecter with whom the pyramid it self will be filled
            for (int i = 0; i < pyramidSize; i++) //Displays the pyramid
            {
                int pyramidSideLenght = pyramidLenght - pyramidStepSize * i;
                Console.WriteLine(new string(pyramidSideL, pyramidSideLenght) + 
                    new string(pyramidFill, (pyramidStepSize * 2) * i) + 
                    new string(pyramidSideR, pyramidSideLenght));
            }
            Console.ReadKey();
        }
    }
}
