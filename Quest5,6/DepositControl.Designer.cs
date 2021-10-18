
namespace Quest5
{
    partial class DepositControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepositBox
            // 
            this.DepositBox.Location = new System.Drawing.Point(266, 193);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(212, 22);
            this.DepositBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bDeposit
            // 
            this.bDeposit.Location = new System.Drawing.Point(333, 238);
            this.bDeposit.Name = "bDeposit";
            this.bDeposit.Size = new System.Drawing.Size(75, 35);
            this.bDeposit.TabIndex = 2;
            this.bDeposit.Text = "Deposit";
            this.bDeposit.UseVisualStyleBackColor = true;
            this.bDeposit.Click += new System.EventHandler(this.bDeposit_Click);
            // 
            // DepositControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bDeposit);
            this.Controls.Add(this.DepositBox);
            this.Name = "DepositControl";
            this.Size = new System.Drawing.Size(818, 497);
            this.Load += new System.EventHandler(this.DepositControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DepositBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bDeposit;
    }
}
