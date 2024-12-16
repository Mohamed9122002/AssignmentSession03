using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Write a program that takes a number from the user then print yes if that number can be 
            //    divided by 3 and 4 otherwise print no
            //Console.WriteLine("Pleaes Enter Number");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //} else
            //    Console.WriteLine("No");
            #endregion
            #region Q02
            //2 - Write a program that allows the user to insert an integer then
            //    print negative if it is negative number otherwise print positive.
            //bool Flag;
            //int Number;
            //do
            //{
            //    Console.WriteLine("Please Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag);
            //if (Number > 0)
            //    Console.WriteLine("Positive");
            //else
            //    Console.WriteLine("Negative");

            #endregion
            #region Q03
            //3 - Write a program that takes 3 integers from the user 
            //    then prints the max element and the min element.

            //Console.WriteLine("Please Enter Number01");
            //int Number01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Nubmer02");
            //int Number02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Number03");
            //int Number03= int.Parse(Console.ReadLine());
            //if (Number01 > Number02 && Number01 > Number03)
            //{
            //    Console.WriteLine($"The  MAx {Number01}");
            //    if (Number02> Number03)
            //        Console.WriteLine($"The Min {Number03}");
            //    else
            //        Console.WriteLine($"The  Min {Number02}");
            //} else if (Number02 > Number03 && Number02 > Number01)
            //{
            //    Console.WriteLine($"The  MAx {Number02}");
            //    if (Number01 > Number03)
            //        Console.WriteLine($"The Min {Number01}");
            //    else
            //        Console.WriteLine($"The  Min {Number03}");
            //} else if (Number03 > Number01 && Number03 > Number02)
            //{
            //    Console.WriteLine($"The  MAx {Number03}");
            //    if (Number01 > Number02)
            //        Console.WriteLine($"The Min {Number02}");
            //    else
            //        Console.WriteLine($"The  Min {Number01}");
            //}
            // Author 
            //int max = (Number01 > Number02 ? (Number01 > Number03 ? Number01 : Number03) : (Number02 > Number03 ? Number02 : Number03));
            //int min = (Number01 < Number02 ? (Number01 < Number03 ? Number01 : Number03) : (Number02 < Number03 ? Number02 : Number03));

            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion
            #region Q04
            //4 - Write a program that allows the user to insert an integer number then check
            //    If a number is even or odd

            //bool Flag;
            //int Number;
            //do
            //{
            //    Console.WriteLine("Please Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (!Flag);
            //if (Number % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("Odd");

            #endregion

            #region Q05
            //5 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then
            //    print(vowel) otherwise print(consonant).
            //Console.WriteLine("Please Enter Character ");
            //char Character;
            //char.TryParse(Console.ReadLine(),out Character);
            //switch(Character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}
            #endregion

            #region Q07
            //7 - Write a program that allows the user to insert an integer then
            //    print a multiplication table up to 12
            //bool Flag;
            //int Number;
            //do
            //{
            //    Console.WriteLine("Please Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while(!Flag);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($" Print Table Up To 12 { Number * i}");
            //}
            #endregion

            #region Q08
            //8 - Write a program that allows to user to insert number then print 
            //    all even numbers between 1 to this number
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Please Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag);
            //for (int i = 1; i <= Number; i++)

            //    if (i % 2 == 0)
            //        Console.WriteLine($"Print{i}");

            #endregion

            #region Q09
            // Console.WriteLine("Please Enter Number");
            // //double number = int.Parse(Console.ReadLine());
            // int Number = int.Parse(Console.ReadLine());
            // Console.WriteLine("Pelase Enter Powr");
            ////double Power = int.Parse(Console.ReadLine());
            // int  Power = int.Parse(Console.ReadLine());

            //double result = Math.Pow(number, Power);
            //Console.WriteLine(result);

            //anthor Answer
            //int result = 1;
            //for (int i = 1; i <=Power ; i++)
            //{
            //    result *= Number;  
            //}
            //Console.WriteLine(result);
            #endregion
            #region Q11

            //int Number;
            //Console.WriteLine("enter month number:");
            //Number = int.Parse(Console.ReadLine());

            //switch (Number)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("number of days 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("number of days 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("number of days 28");
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;


            //}
            #endregion
            #region Q18
            //18 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            //  - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //  - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //  - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //  - If the worker takes more than 5 hours, they are required to leave the company.
            //  To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            //int Time;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Please Enter Time by take work ");
            //    Flag = int.TryParse(Console.ReadLine(), out Time);
            //} while (!Flag);
            //if (Time >= 2 && Time <=3)
            //    Console.WriteLine("efficiency");
            //else if (Time >= 3 && Time <= 4)
            //    Console.WriteLine("increase their speed");
            //else if (Time >= 4 && Time <= 5)
            //    Console.WriteLine("provided with training to enhance ");
            //else if (Time >= 5)
            //    Console.WriteLine("leave the company");
            #endregion
        }
    }
}
