namespace Theme
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,ISettings> settings = new Dictionary<string,ISettings>();
            settings.Add("LightTheme", new ConsoleTheme() { BackgroundColor = ConsoleColor.White, FackgroundColor = ConsoleColor.Black });
            settings.Add("DarkTheme", new ConsoleTheme() { BackgroundColor = ConsoleColor.Black, FackgroundColor = ConsoleColor.White });
            settings.Add("Small", new ConsoleWindowSetting() { height = Console.WindowHeight/2, width = Console.WindowWidth/2 });
            settings.Add("Big", new ConsoleWindowSetting() { height = Console.WindowHeight * 2, width = Console.WindowWidth * 2 });
            while (true)
            {
                Console.WriteLine("Please choose: ");
                Console.WriteLine("1- light, 2-dark, 3-window size 4- small size");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("1- light, 2-dark, 3-window size, 4- small size");
                }
                switch (choice)
                {
                    case 1:
                        settings["LightTheme"].Apply();
                        Console.WriteLine("Light Theme Applied");
                        break;
                    case 2:
                        settings["DarkTheme"].Apply();
                        Console.WriteLine("Dark Theme Applied");
                        break;
                    case 3:
                        settings["Big"].Apply();
                        Console.WriteLine("ffff");
                        break;
                    case 4:
                        settings["Small"].Apply();
                        break;
                    default:
                        {
                            Console.ResetColor();
                            
                        }

                        break;
                }
            }
        }
    }
}