using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;
            var array1 = GenerateRandomArray(arraySize);
            ModifyArray arrayToModify = new ModifyArray(array1);
            Console.WriteLine($"Array1 = {String.Join(" ", arrayToModify.ReturnModified())}");
            Console.WriteLine($"Array2 = {String.Join(" ", arrayToModify.ReturnUnmodified())}");
            Console.ReadKey();
        }

        static public int [] GenerateRandomArray(int size)
        {
            var array = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            return array;
        }
    }

    public class ModifyArray
    {
        private int [] _array;

        public ModifyArray(int [] array)
        {
            _array = array;
        }

        public int[] ReturnUnmodified()
        {
            return _array;
        }

        public int[] ReturnModified()
        {
            int[] arrayNew=new int [_array.Length];
            _array.CopyTo(arrayNew,0);
            arrayNew[arrayNew.Length - 1] = -7;
            return arrayNew;
        }
    }
}
