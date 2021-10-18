namespace Quest3
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
            this.bCheck = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(347, 166);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 3;
            this.bCheck.Text = "Add";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(260, 125);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(248, 22);
            this.NameBox.TabIndex = 2;
            this.NameBox.Text = " Student Name";
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.TextBox NameBox;
    }
}

