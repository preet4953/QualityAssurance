using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As2ConsoleApp
{
    class Program
    {
        //Entry point of the program
        static void Main(string[] args)
        {
            //Program exist in  menu method
            menu();
            
            //This piece of code is to keep the console window open,even after the program ended
            Console.ReadLine();

        }
        // A static method
        static void menu()
        {
            Rectangle rec = new Rectangle();
            String someinput;
            bool run = true;
            //To keep showing the menu
            while (run)
            {
                Console.WriteLine(" press \n 1.Get Rectangle Length  2.Change Rectangle Length  3.Get Rectangle Width \n 4.Change Rectangle Width  5.Get Rectangle Height  6.Change Rectangle Height \n 7.Get Rectangle Volume  8.Exit");
                someinput = Console.ReadLine();
                if (intCheck(someinput))
                {       //switch statement to control the statement
                        switch (int.Parse(someinput))
                        {
                            case 1:
                                Console.WriteLine("Rectangle length is " + rec.GetLength());
                                break;
                            
                            case 2:
                            bool success = true;
                            while (success) {
                                string len;
                                Console.WriteLine("please enter the length of the rectangle");
                                len = Console.ReadLine();
                                if (intCheck(len))
                                {
                                    rec.SetLength(int.Parse(len));
                                    Console.WriteLine("Rectangle Length changed");
                                    success = false;
                                }
                                else if (string.IsNullOrWhiteSpace(len))
                                {

                                    Console.WriteLine("please enter a positive number only \n");
                                }
                                
                            }
                                

                                break;
                            
                            case 3:
                                Console.WriteLine("Rectangle width is " + rec.GetWidth());
                                break;
                            
                        
                            case 4:
                            bool success2 = true;
                            while (success2)
                            {
                                string Wid;
                                Console.WriteLine("please enter the Width of the rectangle");
                                Wid = Console.ReadLine();
                                if (intCheck(Wid))
                                {
                                    rec.SetWidth(int.Parse(Wid));
                                    Console.WriteLine("Rectangle Width changed");
                                    success2 = false;
                                }
                                else if (string.IsNullOrWhiteSpace(Wid))
                                {
                                    Console.WriteLine("please enter a positive number only");
                                }
                                
                            }

                            break;
                            
                            case 5:
                                Console.WriteLine("Rectangle height is " + rec.GetHeight());
                            
                            break;
                            
                            case 6:
                            bool success3 = true;
                            while (success3)
                            {

                                string Heig;
                                Console.WriteLine("please enter the Height of the rectangle");
                                Heig = Console.ReadLine();
                                if (intCheck(Heig))
                                {
                                    rec.SetHeight(int.Parse(Heig));
                                    Console.WriteLine("Rectangle Height changed");
                                    success3 = false;
                                }
                                else if (string.IsNullOrWhiteSpace(Heig))
                                {
                                    Console.WriteLine("please enter a positive number only");
                                }
                                
                            }
                            break;


                        case 7:
                                Console.WriteLine("Rectangle volume is " + rec.GetVolume());
                                break;
                            
                        
                        case 8:
                                run = false;
                                break;
                            
                        
                        default:
                                Console.WriteLine("Please enter a valid input");
                                break;
                        }
                }
                else if (string.IsNullOrWhiteSpace(someinput))
                {
                    Console.WriteLine("please enter a positive number only");

                }
                
            }
            
        }
           
        

















        static bool intCheck(string somevalue)
        { int aNumber;
            bool success = int.TryParse(somevalue, out aNumber);
            if (success)
            {
                if(aNumber > 0)
                {
                    return success;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                return false;
            }
            
            
        }
    }
}
