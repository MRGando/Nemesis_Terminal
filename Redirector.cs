using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;

namespace Terminal
{
    class Redirector
    {
        public static void menu()
        {
            try {
                Console.ResetColor();
                Console.Clear();
                string brand = @" _______                               .__        
 \      \   ____   _____   ____   _____|__| ______
 /   |   \_/ __ \ /     \_/ __ \ /  ___/  |/  ___/
/    |    \  ___/|  Y Y  \  ___/ \___ \|  |\___ \ 
\____|__  /\___  >__|_|  /\___  >____  >__/____  >
        \/     \/      \/     \/     \/        \/ " + "\n Email : wmails@yahoo.com\n WebSite : fitdesign.ir";

                string padleft = brand.PadLeft(50);
                Console.WriteLine(padleft + "\n");
                Console.WriteLine("\n 1) OpenLink\n 2) OpenApp\n 3) Terminal\n 0) Refresh");
                Console.Write("\n + Choose a tool: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Redirector.OpenLink();
                        break;
                    case 2:
                        Redirector.OpenApp();
                        break;
                    case 3:
                        Console.Clear();
                        Redirector.Terminal();
                        break;
                    case 0:
                        Redirector.menu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n - Invalid option! : option must be between 1 and 3 . ( Wait 5 seconds ...)");
                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                        Redirector.menu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" - Something went Wrong! ( Wait 5 seconds ... )");
                Console.ResetColor();
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Redirector.menu();
            }
        }






        public static void OpenLink() {
            Console.WriteLine(@"________                       .____    .__        __    
\_____  \ ______   ____   ____ |    |   |__| ____ |  | __
 /   |   \\____ \_/ __ \ /    \|    |   |  |/    \|  |/ /
/    |    \  |_> >  ___/|   |  \    |___|  |   |  \    < 
\_______  /   __/ \___  >___|  /_______ \__|___|  /__|_ \
        \/|__|        \/     \/        \/       \/     \/");
            Console.Write("\n + Time: ");
            string time = Console.ReadLine();
            Console.Write(" + Link: ");
            string link = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (time == "" || link == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Proccess went wrong!");
            }
            else
            {

                Console.WriteLine("\n It's all set , now keep this screen running ..." + "\n\n      * TIP : Make sure you have firefox installed in this path : " + "C\\Program Files\\Mozilla Firefox\\firefox.exe"+
                    "\n      * if you want to cancel this proccess close the Terminal.");
                Console.ResetColor();
                //checking time
                while (1 >= 0)
                {
                    string realTime = DateTime.Now.ToString("HH:mm");
                    if (realTime == time)
                    {
                        Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", link);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n + Redirecting ... >> " + link + "\n\n      * Press \" Enter \" to return .");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            Console.ResetColor();
                        {
                            Redirector.menu();
                        }
                        break;
                        
                    }
                }


            }
        }

        public static void Terminal() 
        {
            Console.Write("~"+Environment.MachineName.ToString()+"\\: ");
            string command = Console.ReadLine();
            switch (command)
                {
                case "":
                    Redirector.Terminal();
                    break;
                case "color1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Redirector.Terminal();
                    break;
                case "color2":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Redirector.Terminal();
                    break;
                case "color3":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Redirector.Terminal();
                    break;
                case "color0":
                    Console.ResetColor();
                    Redirector.Terminal();
                    break;
                case "clear":
                    Console.Clear();
                    Redirector.Terminal();
                    break;
                case "close":
                    Environment.Exit(0);
                    break;
                case "whoami":
                    Console.WriteLine(Environment.MachineName.ToString());
                    Redirector.Terminal();
                    break;
                case "ip":
                    string hostName = Dns.GetHostName(); // Retrive the Name of HOST
                    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString(); 
                    Console.WriteLine("-------------- IP Address --------------\n Host-Name: "+hostName+"\n IP: "+ myIP+ "\n----------------------------------------");
                    Redirector.Terminal();
                    break;
                case "version":
                    Console.WriteLine("Nemesis - 1.0.0v");
                    Redirector.Terminal();
                    break;
                case "menu":
                    Redirector.menu();
                    break;
                case "help":
                    Console.WriteLine("-------------- HELP --------------\n"+
                        " + color 0 to 3 (ex: color1) : changes the color of Texts.\n"+
                        " + version : shows the current version of Nemesis.\n"+
                        " + menu : Returns to the main menu.\n"+
                        " + ip : shows the hostname and ip of your System.\n"+
                        " + whoami : shows the name of your System.\n"+
                        " + clear : clears the Terminal.\n" +
                        " + close : closes the Terminal.\n" +
                        " + help : shows the Commands list." +
                        "\n----------------------------------");
                    Redirector.Terminal();
                    break;
                default:
                    Console.WriteLine(" - Unknown Command!");
                    Redirector.Terminal();
                    break;
            }
        }


        public static void OpenApp()
        {
            Console.Clear();
            Console.WriteLine(@"________                           _____                 
\_____  \ ______   ____   ____    /  _  \ ______ ______  
 /   |   \\____ \_/ __ \ /    \  /  /_\  \\____ \\____ \ 
/    |    \  |_> >  ___/|   |  \/    |    \  |_> >  |_> >
\_______  /   __/ \___  >___|  /\____|__  /   __/|   __/ 
        \/|__|        \/     \/         \/|__|   |__|    ");
            Console.Write("\n + Time: ");
            string time = Console.ReadLine();
            Console.Write(" + App - Direction: ");
            string AppD = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (time == "" || AppD == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Proccess went wrong! ( Wait 5 seconds ... )");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Redirector.menu();
            }
            else
            {

                Console.WriteLine("\n * It's all set , now keep this screen running ..."+ "\n\n      TIP: * if you want to cancel this proccess close the Terminal.");
                //checking time
                while (1 >= 0)
                {
                    string realTime = DateTime.Now.ToString("HH:mm");
                    if (realTime == time)
                    {
                        Process.Start("explorer", AppD);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n + Redirecting ... >> " + AppD + "\n\n      * Press \" Enter \" to return .");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            Console.ResetColor();
                        {
                            Redirector.menu();
                        }
                        break;

                    }
                }


            }
        }
    }
}
