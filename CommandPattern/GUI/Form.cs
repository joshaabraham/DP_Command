using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandPattern.Business;

namespace CommandPattern.GUI
{
    public partial class CommandForm : Form
    {
        private Command command1;
        private Command command2;
        private Command command3;

        public static StringBuilder FileBuilder = new StringBuilder();

        public CommandForm(Command cmd1, Command cmd2, Command cmd3)
        {
            InitializeComponent();

            this.command1 = cmd1;
            this.command2 = cmd2;
            this.command3 = cmd3;
        }

        
        private void OpenButton_Click(object sender, EventArgs e)
        {
            this.command1.execute();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.command2.execute();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            FileBuilder.Append(this.textBox1.Text + "\n");
            this.textBox1.Clear();
            this.command3.execute();
        }

       
    }
}
