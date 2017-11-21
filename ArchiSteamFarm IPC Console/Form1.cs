using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASF_IPC_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            execute_command("sa");
            command1.Text = (string) Properties.Settings.Default["command1name"];
            command2.Text = (string) Properties.Settings.Default["command2name"];
            command3.Text = (string) Properties.Settings.Default["command3name"];
            command4.Text = (string) Properties.Settings.Default["command4name"];
        }

        private void execute_command(string command)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string htmlCode = client.DownloadString("http://"+ Properties.Settings.Default["ip"] + ":"+ Properties.Settings.Default["port"] + "/IPC?command=" + command);
                    textBox1.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " +htmlCode);
                }
                catch (Exception e)
                {
                    textBox1.AppendText("Error: " + e.Message + "\n");
                }
            }

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            execute_command(textBox2.Text);
            textBox2.Text = ""; 
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void command1_Click(object sender, EventArgs e)
        {
            execute_command((string)Properties.Settings.Default["command1"]);
        }

        private void command2_Click(object sender, EventArgs e)
        {
            execute_command((string)Properties.Settings.Default["command2"]);
        }

        private void command3_Click(object sender, EventArgs e)
        {
            execute_command((string)Properties.Settings.Default["command3"]);
        }

        private void command4_Click(object sender, EventArgs e)
        {
            execute_command((string)Properties.Settings.Default["command4"]);
        }

        private void command1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form = new Form2(1);
                form.ShowDialog();
            }
        }

        private void command2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form = new Form2(2);
                form.ShowDialog();
            }
        }

        private void command3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form = new Form2(3);
                form.ShowDialog();
            }
        }

        private void command4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form = new Form2(4);
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(-1);
            form.ShowDialog();
        }
    }
}
