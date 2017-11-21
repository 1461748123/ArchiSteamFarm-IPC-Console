namespace ASF_IPC_Console
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.command1 = new System.Windows.Forms.Button();
            this.command2 = new System.Windows.Forms.Button();
            this.command3 = new System.Windows.Forms.Button();
            this.command4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(447, 209);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // command1
            // 
            this.command1.Location = new System.Drawing.Point(12, 255);
            this.command1.Name = "command1";
            this.command1.Size = new System.Drawing.Size(100, 23);
            this.command1.TabIndex = 3;
            this.command1.Text = "button2";
            this.command1.UseVisualStyleBackColor = true;
            this.command1.Click += new System.EventHandler(this.command1_Click);
            this.command1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.command1_MouseUp);
            // 
            // command2
            // 
            this.command2.Location = new System.Drawing.Point(118, 255);
            this.command2.Name = "command2";
            this.command2.Size = new System.Drawing.Size(100, 23);
            this.command2.TabIndex = 4;
            this.command2.Text = "button3";
            this.command2.UseVisualStyleBackColor = true;
            this.command2.Click += new System.EventHandler(this.command2_Click);
            this.command2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.command2_MouseUp);
            // 
            // command3
            // 
            this.command3.Location = new System.Drawing.Point(224, 256);
            this.command3.Name = "command3";
            this.command3.Size = new System.Drawing.Size(100, 23);
            this.command3.TabIndex = 5;
            this.command3.Text = "button4";
            this.command3.UseVisualStyleBackColor = true;
            this.command3.Click += new System.EventHandler(this.command3_Click);
            this.command3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.command3_MouseUp);
            // 
            // command4
            // 
            this.command4.Location = new System.Drawing.Point(330, 256);
            this.command4.Name = "command4";
            this.command4.Size = new System.Drawing.Size(100, 23);
            this.command4.TabIndex = 6;
            this.command4.Text = "button5";
            this.command4.UseVisualStyleBackColor = true;
            this.command4.Click += new System.EventHandler(this.command4_Click);
            this.command4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.command4_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(436, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.command4);
            this.Controls.Add(this.command3);
            this.Controls.Add(this.command2);
            this.Controls.Add(this.command1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ArchiSteamFarm IPC Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button command1;
        private System.Windows.Forms.Button command2;
        private System.Windows.Forms.Button command3;
        private System.Windows.Forms.Button command4;
        private System.Windows.Forms.Button button2;
    }
}

