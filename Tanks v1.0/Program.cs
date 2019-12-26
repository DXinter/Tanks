using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tanks
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ControllerMainForm cm;           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
               
                switch (args.Length)
                {
                    case 0: cm = new ControllerMainForm(); break;
                    case 1: cm = new ControllerMainForm(Convert.ToInt32(args[0], new CultureInfo("En", true))); break;
                    case 2: cm = new ControllerMainForm(Convert.ToInt32(args[0], new CultureInfo("En", true)), Convert.ToInt32(args[1], new CultureInfo("En", true))); break;
                    case 3: cm = new ControllerMainForm(Convert.ToInt32(args[0], new CultureInfo("En", true)), Convert.ToInt32(args[1], new CultureInfo("En", true)), Convert.ToInt32(args[2], new CultureInfo("En", true))); break;
                    case 4: cm = new ControllerMainForm(Convert.ToInt32(args[0], new CultureInfo("En", true)), Convert.ToInt32(args[1], new CultureInfo("En", true)), Convert.ToInt32(args[2]), Convert.ToInt32(args[3], new CultureInfo("En", true))); break;
                    default: cm = new ControllerMainForm(); break;// вызываем конструктор по умолчанию если кол во аргументом не соотвествует списку
                        
                }
                
            Application.Run(cm);
        }

       
    }
}
