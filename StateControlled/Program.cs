//Temoso Nare
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControlledLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the students marks one after another.");

            int n = 0;
            int iSum = 0;
            int iMark = 0;


            while (IsAnotherOne())
            {
                n++;
                Console.Write("Mark " + n.ToString() + ":");
                iMark = int.Parse(Console.ReadLine());
                iSum += iMark;
            }

            if (n > 0)
            {
                double dAverage = iSum / (n * 1.0);
                Console.WriteLine("The average mark is " + dAverage.ToString("F1"));
            }
            else
            {
                Console.WriteLine("No mark was entered !!");
            }

            Console.WriteLine("Press any key to exit !!");
            Console.ReadKey();
        }
        static bool IsAnotherOne()
        {
            return MessageBox.Show("Another mark (Y/N)?", "Marks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            /*
            Console.Write("Another Mark (Y/N) ? :");
            bool isAnotherOne = Console.ReadKey().KeyChar.ToString().ToUpper() == "Y";
            Console.WriteLine();
            return isAnotherOne;
            */

        }
    }
}
