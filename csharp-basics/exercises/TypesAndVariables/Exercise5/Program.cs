using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise5
{
    class Program  // This programs creates  auto adjusting table from entries in teachers and classNames arrays.
                   // Both arrays have to be the same lenght!!
    {
        static void Main(string[] args)
        {
            string[] teachers = new string[]
            {
                "Ms. Lapan",
                "Mrs. Gideon",
                "Mr. Davis",
                "Ms. Palmer",
                "Ms. Garcia",
                "Mrs. Barnett",
                "Ms. Johannessen",
                "Mr. James"
            };

            string[] classNames = new string[]
            {
                "English III",
                "Precalculus",
                "Music Theory",
                "Biotechnology",
                "Principles of Technology I",
                "Latin II",
                "AP US History",
                "Business Computer Infomation Systems"
            };

            int tableSize = classNames.Length;
            int longestClassNameLength = 0;
            int longestTeacherNameLength = 0;
            int tableNumberLength = tableSize.ToString().Length;

            foreach (string className in classNames)        //Finds longest name of a class
            {
                if (className.Length > longestClassNameLength) longestClassNameLength = className.Length;
            }

            foreach (string teacherName in teachers)        // Finds longest name of a teahcer.
            {
                if (teacherName.Length > longestTeacherNameLength) longestTeacherNameLength = teacherName.Length;
            }

            for (int i = 0; i < tableSize; i++)             // Makes all class name entries the same size
            {
                int lengthDiference = longestClassNameLength - classNames[i].Length;
                string spaceBeforWord = "";
                for (int k = 0; k < lengthDiference; k++)
                {
                    spaceBeforWord += " ";
                }

                classNames[i] = spaceBeforWord + classNames[i];
            }

            for (int i = 0; i < tableSize; i++)                                     // Makes all teacher name entries the same size. 
            {                                                                    
                int lengthDiference = longestTeacherNameLength - teachers[i].Length;
                string spaceBeforWord = "";
                for (int k = 0; k < lengthDiference; k++)
                {
                    spaceBeforWord += " ";
                }

                teachers[i] = spaceBeforWord + teachers[i];
            }
            int lineTotalLength = longestClassNameLength + longestTeacherNameLength + tableNumberLength + 8; // Magic number 8.
                                                                                                             // This number is for
                                                                                                             // the spaces in the table                                                                                                            
            string tableEnds = "+";    // This is the tables first and last line
            for (int i = 0; i < lineTotalLength; i++)
            {
                tableEnds += "-";
            }

            tableEnds += "+";       //Adds '+' sing to the end of the line

            Console.WriteLine(tableEnds);

            for (int i = 0; i < tableSize; i++)         //Loop that writes the table itself from given
            {
                string tableNumber = (i + 1).ToString();
                while (true)
                {
                    if (tableNumber.Length == tableNumberLength) break;    //Adjusts the table number size acording to digits
                    tableNumber = " " + tableNumber;
                }
                Console.WriteLine($"| {tableNumber} | {classNames[i]} | {teachers[i]} |");

            }
            Console.WriteLine(tableEnds);
            Console.ReadKey();
        }

    }
}
