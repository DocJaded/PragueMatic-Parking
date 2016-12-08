using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueMatic_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] arrayName = new string[100, 2];
            char line = '0';
            while (line != -1)

            {

                Console.WriteLine("Welcome to PragueMatic Parking!");
                Console.WriteLine(@"    ____                              __  ___      __  _         ____             __   _               ");
                Console.WriteLine(@"   / __ \_________ _____ ___  _____  /  |/  /___ _/ /_(_)____   / __ \____ ______/ /__(_)___  ____ _   ");
                Console.WriteLine(@"  / /_/ / ___/ __ `/ __ `/ / / / _ \/ /|_/ / __ `/ __/ / ___/  / /_/ / __ `/ ___/ //_/ / __ \/ __ `/   ");
                Console.WriteLine(@" / ____/ /  / /_/ / /_/ / /_/ /  __/ /  / / /_/ / /_/ / /__   / ____/ /_/ / /  / ,< / / / / / /_/ /    ");
                Console.WriteLine(@"/_/   /_/   \__,_/\__, /\__,_/\___/_/  /_/\__,_/\__/_/\___/  /_/    \__,_/_/  /_/|_/_/_/ /_/\__, /     ");
                Console.WriteLine(@"                 /____/                                                                    /____/      ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine();
                Console.WriteLine("1. Park a vehicle");
                Console.WriteLine();
                Console.WriteLine("2. Dismiss a vehicle");
                Console.WriteLine();
                Console.WriteLine("3. Search for a vehicle");
                Console.WriteLine();
                Console.WriteLine("4. List all parking spots");
                Console.WriteLine();
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.ResetColor();

                line = Console.ReadKey().KeyChar;   //User input
                Console.WriteLine();

                switch (line)
                {

                    case '0':
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("Case 0. Waddap");
                        Console.ResetColor();
                        break;

                    case '1': // ------Register a vehicle------

                        Console.WriteLine("Please enter the type of vehicle (1 for Motorcycle, 2 for car)");

                        char vehicletype = Console.ReadKey().KeyChar;

                        if (vehicletype == '1')   //if it's a motorcycle
                        {

                            for (int i = 0; i < 101; i++)  //Check to make sure there's room 
                            {

                                for (int j = 0; j < 2; j++)
                                {

                                    //Console.WriteLine(arrayName[i, j]);

                                    if (arrayName[i, j] == null)
                                    {
                                        //Console.WriteLine("Parking spot found at " + "[" + i + "," + j + "]");
                                        Console.WriteLine();
                                        Console.WriteLine("Please enter the 6-digit license plate number of the motorcycle you wish to check in. ");

                                        string addlicenseplate = Console.ReadLine();

                                        arrayName[i, j] = addlicenseplate;
                                        //Console.ForegroundColor = ConsoleColor.Magenta;
                                        //Console.WriteLine(arrayName[i, j]);
                                        Console.WriteLine();
                                        //Console.ResetColor();
                                        goto case '0';
                                    }
                                    //else Console.WriteLine("Sorry, there are no vacancies at this time.");

                                }

                                
                            }

                            Console.WriteLine("Sorry, there are no vacancies at this time.");

                        }

                        if (vehicletype == '2')   //It's a car
                        {


                            for (int i = 0; i < 101; i++)  //Check to make sure there's room (maybe foreach?)
                            {


                                //Console.WriteLine(arrayName[i, 0]);

                                if (arrayName[i, 0] == null && arrayName[i, 1] == null)
                                {
                                    //Console.WriteLine("Parking spot found at " + "[" + i + "," + 0 + "]");
                                    Console.WriteLine();
                                    Console.WriteLine("Please enter the 6-digit license plate number of the car you wish to check in. ");

                                    string addlicenseplate = Console.ReadLine();

                                    arrayName[i, 0] = addlicenseplate;
                                    arrayName[i, 1] = addlicenseplate;
                                    //Console.ForegroundColor = ConsoleColor.Magenta;
                                    //Console.WriteLine(arrayName[i, 0]);
                                    Console.WriteLine();
                                    //Console.ResetColor();
                                    goto case '0';
                                }

                                //else Console.WriteLine("Sorry, there are no vacancies at this time.");


                            }

                            Console.WriteLine("Sorry, there are no vacancies at this time.");
                        }

                        else

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yeah....no.");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;



                    case '2': // ------Dismiss a vehicle------  
                                      
                        Console.WriteLine();
                        Console.WriteLine("Please enter the 6-digit license plate number of the vehicle you wish to dismiss. ");
                        string licenseplate = Console.ReadLine();

                        for (int i = 0; i < 101; i++)
                        {

                            for (int j = 0; j < 2; j++)
                            {

                                //Console.WriteLine(arrayName[i, j]);

                                if (arrayName[i, j] == licenseplate)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    //Console.WriteLine(licenseplate + " found at " + "[" + i + "," + j + "]");
                                    Console.WriteLine(licenseplate + " dismissed!");
                                    Console.ResetColor();
                                    
                                    if (arrayName[i, 0] != arrayName[i, 1])

                                    {
                                        
                                        arrayName[i, j] = null;
                                        
                                    }

                                    if (arrayName[i, 0] == arrayName[i, 1])

                                    {
                                        
                                        arrayName[i, 0] = null;
                                        arrayName[i, 1] = null;
                                        

                                    }
                                    
                                    break;
                                    
                                }

                                
                                else
                                    
                                
                                
                                break;

                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(licenseplate + " not found.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        break;

                    case '3': // ------Search for a vehicle------

                        Console.WriteLine();
                        Console.WriteLine("Please enter the 6-digit license plate number of the vehicle you wish to Find. ");
                        string xlicenseplate = Console.ReadLine();

                        for (int i = 0; i < 101; i++)
                        {

                            for (int j = 0; j < 2; j++)
                            {

                                //Console.WriteLine(arrayName[i, j]);

                                if (arrayName[i, j] == xlicenseplate)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(xlicenseplate + " found at parking spot number" + i + ".");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    break;

                                }
                                else
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                //Console.WriteLine(xlicenseplate + " not found at " + "[" + i + "," + j + "]");
                                Console.ResetColor();
                                break;
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(xlicenseplate + " not found.");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        
                        break;

                    case '4': // ------list all parking spots------


                        
                        Console.Clear();
                        Console.WriteLine("Parking Lot Status");
                        int spot = 0;

                        foreach (string element in arrayName)
                        {
                            
                            string yomama = ("|" + spot / 2 + "|" + element + "| " + "\t");
                            
                            Console.Write("{0, -2}" , yomama); //writes the string defined as yomama, 
                                                               //not in a line but with a defined tab 
                                                               //(4 in this case, which is what the second number is for)
                            spot++;
                        }

                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case '5': // ------EXIT------

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Looks like it's closing time.  Have a good night! ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;


                    default:

                            Console.Clear();


                            Console.WriteLine(@"                                    ");
                            Console.WriteLine(@"         ▒▒▒▒▒▄██████████▄▒▒▒▒▒     ");
                            Console.WriteLine(@"         ▒▒▒▄██████████████▄▒▒▒     ");
                            Console.WriteLine(@"         ▒▒██████████████████▒▒     ");
                            Console.WriteLine(@"         ▒▐███▀▀▀▀▀██▀▀▀▀▀███▌▒     ");
                            Console.WriteLine(@"         ▒███▒▒▌■▐▒▒▒▒▌■▐▒▒███▒     ");
                            Console.WriteLine(@"         ▒▐██▄▒▀▀▀▒▒▒▒▀▀▀▒▄██▌▒     ");
                            Console.WriteLine(@"         ▒▒▀████▒▄▄▒▒▄▄▒████▀▒▒     ");
                            Console.WriteLine(@"         ▒▒▐███▒▒▒▀▒▒▀▒▒▒███▌▒▒     ");
                            Console.WriteLine(@"         ▒▒███▒▒▒▒▒▒▒▒▒▒▒▒███▒▒     ");
                            Console.WriteLine(@"         ▒▒▒██▒▒▀▀▀▀▀▀▀▀▒▒██▒▒▒     ");
                            Console.WriteLine(@"         ▒▒▒▐██▄▒▒▒▒▒▒▒▒▄██▌▒▒▒     ");
                            Console.WriteLine(@"         ░░▄▄▓▀▀░░░░░░░▒▒▒▀▀▀▓▄░    ");
                            Console.WriteLine(@"         ░▐▓▒░░▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▓    ");

                            Console.WriteLine("You have chosen to execute Harambe.  Please confirm (Y/N)");
                            string shootHarambe;
                            shootHarambe = Convert.ToString(Console.ReadLine());
                            if (shootHarambe == "Y" || shootHarambe == "y")

                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"                                    ");
                            Console.WriteLine(@"         ▒▒▒▒▒▄██████████▄▒▒▒▒▒     ");
                            Console.WriteLine(@"         ▒▒▒▄██████████████▄▒▒▒     ");
                            Console.WriteLine(@"         ▒▒██████████████████▒▒     ");
                            Console.WriteLine(@"         ▒▐███▀▀▀▀▀██▀▀▀▀▀███▌▒     ");
                            Console.WriteLine(@"         ▒███▒▒▌X▐▒▒▒▒▌X▐▒▒███▒     ");
                            Console.WriteLine(@"         ▒▐██▄▒▀▀▀▒▒▒▒▀▀▀▒▄██▌▒     ");
                            Console.WriteLine(@"         ▒▒▀████▒▄▄▒▒▄▄▒████▀▒▒     ");
                            Console.WriteLine(@"         ▒▒▐███▒▒▒▀▒▒▀▒▒▒███▌▒▒     ");
                            Console.WriteLine(@"         ▒▒███▒▒▒▒▒▒▒▒▒▒▒▒███▒▒     ");
                            Console.WriteLine(@"         ▒▒▒██▒▒▀▀▀▀▀▀▀▀▒▒██▒▒▒     ");
                            Console.WriteLine(@"         ▒▒▒▐██▄▒▒▒▒▒▒▒▒▄██▌▒▒▒     ");
                            Console.WriteLine(@"         ░░▄▄▓▀▀░░░░░░░▒▒▒▀▀▀▓▄░    ");
                            Console.WriteLine(@"         ░▐▓▒░░▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▓    ");
                            Console.ResetColor();
                            Console.WriteLine("Press any key to continue. You monster.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        else

                            Console.WriteLine("Let's try again.");
                            

                        break;

                } //End of switch cases
            }
        }

    }
} 