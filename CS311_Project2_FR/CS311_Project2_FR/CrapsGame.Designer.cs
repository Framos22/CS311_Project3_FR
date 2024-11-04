namespace CrapsGame
{
    partial class MainForm
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(50, 50);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(62, 25);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.Text = "Die 1";
            this.lblDie1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(200, 50);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(62, 25);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.Text = "Die 2";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(180, 130);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(180, 25);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: $100.00";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(50, 130);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 31);
            this.txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(50, 170);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(136, 38);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(50, 210);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(70, 25);
            this.lblGameStatus.TabIndex = 5;
            this.lblGameStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 412);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Name = "Form1";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblGameStatus;
    }
}

