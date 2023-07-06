using System;

namespace Project2
{
    class Program
    {
        private static Director? director;
        private static bool modeIsSet = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Document Builder Console Client\n");
            DisplayCommands();

            while (true)
            {
                string input = Console.ReadLine() ?? "";
                string[] commands = input.Split(':');
                ExecuteCommands(commands);
            }
        }

        private static void DisplayCommands()
        {
            Console.WriteLine("\nUsage:\n");
            Console.WriteLine("\thelp".PadRight(30) + "-Prints Usage (this page).\n");
            Console.WriteLine("\tmode: <JSON | XML>".PadRight(30) + "-Sets mode to JSON or XML. Must be set before creating or closing.\n");
            Console.WriteLine("\tbranch: <name>".PadRight(30) + "-Creates a new branch, assinging it the passed name.\n");
            Console.WriteLine("\tleaf: <name>: ‹content>".PadRight(30) + "-Creates a new leaf, assigning the passed name and content.\n");
            Console.WriteLine("\tclose".PadRight(30) + "-Closes the current branch, as long as it is not the root.\n");
            Console.WriteLine("\tprint".PadRight(30) + "-Prints the doc in its current state to the console.\n");
            Console.WriteLine("\texit".PadRight(30) + "-Exits the application.\n");
        }

        private static void ExecuteCommands(string[] commands)
        {
            string userCommand = commands[0].ToLower();

            if (userCommand == "help")
            {
                DisplayCommands();
            }
            else if (userCommand == "mode")
            {
                if (commands[1].ToUpper() == "JSON")
                    director = new Director(new JSONBuilder());
                else if (commands[1].ToUpper() == "XML")
                    director = new Director(new XMLBuilder());

                modeIsSet = true;
            }
            else if (modeIsSet)
            {
                switch(userCommand)
                {
                    case "branch":
                        director!.name = commands[1];
                        director!.BuildBranch();
                        break;

                    case "leaf":
                        director!.name = commands[1];
                        director!.content = commands[2];
                        director!.BuildLeaf();
                        break;

                    case "print":
                        director!.PrintDocument();
                        break;

                    case "close":
                        director!.CloseBranch();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input. For usage, type 'help'.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error. Mode has not been set. For usage, type 'help'.");
            }
        }
    }
}
