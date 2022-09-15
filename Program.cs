namespace Guess_MyNumber_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═══╗                     ╔═╗╔═╗     ╔═╗ ╔╗        ╔╗              ╔═══╗             \r\n║╔═╗║                     ║║╚╝║║     ║║╚╗║║        ║║              ║╔═╗║             \r\n║║ ╚╝╔╗╔╗╔══╗╔══╗╔══╗     ║╔╗╔╗║╔╗ ╔╗║╔╗╚╝║╔╗╔╗╔╗╔╗║╚═╗╔══╗╔═╗     ║║ ╚╝╔══╗ ╔╗╔╗╔══╗\r\n║║╔═╗║║║║║╔╗║║══╣║══╣╔═══╗║║║║║║║║ ║║║║╚╗║║║║║║║╚╝║║╔╗║║╔╗║║╔╝╔═══╗║║╔═╗╚ ╗║ ║╚╝║║╔╗║\r\n║╚╩═║║╚╝║║║═╣╠══║╠══║╚═══╝║║║║║║║╚═╝║║║ ║║║║╚╝║║║║║║╚╝║║║═╣║║ ╚═══╝║╚╩═║║╚╝╚╗║║║║║║═╣\r\n╚═══╝╚══╝╚══╝╚══╝╚══╝     ╚╝╚╝╚╝╚═╗╔╝╚╝ ╚═╝╚══╝╚╩╩╝╚══╝╚══╝╚╝      ╚═══╝╚═══╝╚╩╩╝╚══╝\r\n                                ╔═╝║                                                 \r\n                                ╚══╝                                                 \r\n");
            Console.ForegroundColor = ConsoleColor.White;

            string Name = "";
            Console.Write("Bevor wir mit dem Spiel beginnen, tippe bitte deinen Namen ein: " + Name);
            Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hallo " + Name + " ,in diesem Spiel ist es dein Ziel mit möglichst wenig versuche, meine Zufälig generierte Zahl von \n1-100 herauszufinden");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------");


            NumberGuesser:
            Random rnd = new Random();
            int randNumb = rnd.Next(1, 100);
            int guessNumb;
            int versueche = 0;
            bool zahlGefunden = false;
            string trueFalse = "" ;
           

            while (!zahlGefunden)
            {

                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Tippe eine Zahl zwischen 1-100: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    guessNumb = Convert.ToInt32(Console.ReadLine());


                    if (guessNumb > 100 || guessNumb < 1) // 1-100
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Bitte eine Zahl im Rahmen von 1-100 raten!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");

                    }

                    else if (guessNumb > randNumb) // Zu hoch geraten
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Zu hoch geraten. Versuch mal TIEFER");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");
                        versueche++;
                    }

                    else if (guessNumb < randNumb) // Zu tief geraten
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Zu tief. Versuch mal HÖHER");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");
                        versueche++;
                    }

                    else if (guessNumb == randNumb) // Richtige Zahl eratet
                    {
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bravo " + Name + "! Du hast meine Zahl eraten!");
                        Console.ForegroundColor = ConsoleColor.White;
                        versueche++;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Du hattest insegsamt " + versueche + " versuche");
                        Console.ForegroundColor = ConsoleColor.White;
                        zahlGefunden = true;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Willst du wieder Spielen? [Ja/Nein]: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        trueFalse = Console.ReadLine();
                        Console.WriteLine("--------------------------------");
                        
                        if (trueFalse == "Ja")
                        {
                            goto NumberGuesser;
                        }
                    }

                }
                catch // Keine Zahl eingegeben
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("KEINE ZEICHEN Eingeben. Bitte eine Zahl im Rahmen von 1-100 raten!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("");
                }
            }
        }
    }
}