using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASF_IPC_Console
{
    public partial class Form2 : Form
    {
        private int _commandnum;
        public Form2(int commandnum)
        {
            _commandnum = commandnum;
            InitializeComponent();
            if (_commandnum != - 1)
            {
                Text = "Command " + _commandnum;
            } else
            {
                Text = "Settings";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_commandnum != -1)
            {
                namebox.Text = (string)Properties.Settings.Default["command" + _commandnum + "name"];
                commandbox.Text = (string)Properties.Settings.Default["command" + _commandnum];
            } else
            {
                lable1.Text = "IP";
                namebox.Text = (string)Properties.Settings.Default["ip"];
                lable2.Text = "Port";
                commandbox.Text = (string)Properties.Settings.Default["port"];
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_commandnum != -1)
            {
                Properties.Settings.Default["command" + _commandnum + "name"] = namebox.Text;
                Properties.Settings.Default["command" + _commandnum] = commandbox.Text;
                Properties.Settings.Default.Save();
            } else
            {
                Properties.Settings.Default["ip"] = namebox.Text;
                Properties.Settings.Default["port"] = commandbox.Text;
                Properties.Settings.Default.Save();
            }
            this.Close();
        }
    }
}
