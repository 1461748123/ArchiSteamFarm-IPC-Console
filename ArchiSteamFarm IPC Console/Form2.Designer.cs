namespace ASF_IPC_Console
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.namebox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.commandbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(72, 12);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(220, 20);
            this.namebox.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(15, 64);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(277, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 15);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(35, 13);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Name";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(12, 41);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(54, 13);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Command";
            // 
            // commandbox
            // 
            this.commandbox.Location = new System.Drawing.Point(72, 38);
            this.commandbox.Name = "commandbox";
            this.commandbox.Size = new System.Drawing.Size(220, 20);
            this.commandbox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 97);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.commandbox);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.namebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox commandbox;
    }
}