using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks_v1._0
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
                case 1: cm = new ControllerMainForm(Convert.ToInt32(args[0])); break;
                case 2: cm = new ControllerMainForm(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])); break;
                case 3: cm = new ControllerMainForm(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2])); break;
                case 4: cm = new ControllerMainForm(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]), Convert.ToInt32(args[3])); break;
                default: cm = new ControllerMainForm(); break;// вызываем конструктор по умолчанию если кол во аргументом не соотвествует списку
            }

            Application.Run(cm);
        }
    }
}
