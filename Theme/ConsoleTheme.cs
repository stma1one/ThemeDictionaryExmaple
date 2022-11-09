using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme
{
    public class ConsoleWindowSetting:ISettings
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Apply()
        {
             
            Console.WindowWidth = width;
            Console.WindowHeight = height;
        }
    }
    public class ConsoleTheme : ISettings
    {
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor FackgroundColor { get; set; }
        public void Apply()
        {
            Console.ForegroundColor = FackgroundColor; 
            Console.BackgroundColor = BackgroundColor;
            Console.Clear();
        }
    }
}
