using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandPattern.GUI;
using CommandPattern.Business;

namespace CommandPattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileDocument mainDoc = new FileDocument("Test.txt");

            Command c1 = new OpenCommand(mainDoc);
            Command c2 = new CloseCommand(mainDoc);
            Command c3 = new WriteCommand(mainDoc, CommandForm.FileBuilder);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CommandForm(c1, c2, c3));
        }
    }
}
