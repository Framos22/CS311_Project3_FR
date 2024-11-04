namespace CS311_Project3_FR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbMushrooms = new System.Windows.Forms.CheckBox();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS311_Project3_FR.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1501, 496);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(270, 504);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 33);
            this.cboSize.TabIndex = 1;
            this.cboSize.Text = "Size: ";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(436, 508);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(85, 29);
            this.rdoThin.TabIndex = 2;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(575, 507);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(95, 29);
            this.rdoThick.TabIndex = 3;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(701, 507);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(118, 29);
            this.rdoRegular.TabIndex = 4;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(270, 556);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(142, 29);
            this.ckbPepperoni.TabIndex = 5;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(270, 619);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(129, 29);
            this.ckbSausage.TabIndex = 6;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Location = new System.Drawing.Point(270, 683);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(203, 29);
            this.ckbCanadianBacon.TabIndex = 7;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(270, 742);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(251, 29);
            this.ckbSpicyItalianSausage.TabIndex = 8;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(597, 556);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(101, 29);
            this.ckbOnion.TabIndex = 9;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Location = new System.Drawing.Point(597, 619);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(178, 29);
            this.ckbGreenPepper.TabIndex = 10;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Location = new System.Drawing.Point(597, 683);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(163, 29);
            this.ckbBlackOlives.TabIndex = 11;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Location = new System.Drawing.Point(597, 742);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(169, 29);
            this.ckbGreenOlives.TabIndex = 12;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Location = new System.Drawing.Point(818, 556);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(204, 29);
            this.ckbBananaPeppers.TabIndex = 13;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Location = new System.Drawing.Point(818, 619);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(132, 29);
            this.ckbJalepeno.TabIndex = 14;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Location = new System.Drawing.Point(818, 683);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(174, 29);
            this.ckbExtraCheese.TabIndex = 15;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushrooms
            // 
            this.ckbMushrooms.AutoSize = true;
            this.ckbMushrooms.Location = new System.Drawing.Point(818, 742);
            this.ckbMushrooms.Name = "ckbMushrooms";
            this.ckbMushrooms.Size = new System.Drawing.Size(145, 29);
            this.ckbMushrooms.TabIndex = 16;
            this.ckbMushrooms.Text = "Mushroom";
            this.ckbMushrooms.UseVisualStyleBackColor = true;
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(270, 804);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(629, 247);
            this.rtfOrderSummary.TabIndex = 17;
            this.rtfOrderSummary.Text = "Order Summary: ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(1047, 804);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 31);
            this.txtSubTotal.TabIndex = 18;
            this.txtSubTotal.Text = "SubTotal: ";
            this.txtSubTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(1047, 865);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 31);
            this.txtTax.TabIndex = 19;
            this.txtTax.Text = "Tax: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1047, 928);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 31);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Text = "Total: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1047, 983);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(265, 68);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 1398);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.ckbMushrooms);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenOlives);
            this.Controls.Add(this.ckbBlackOlives);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbPepperoni);
            this.Controls.Add(this.rdoRegular);
            this.Controls.Add(this.rdoThick);
            this.Controls.Add(this.rdoThin);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.pictureBox1);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Felix\'s Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbCanadianBacon;
        private System.Windows.Forms.CheckBox ckbSpicyItalianSausage;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbGreenPepper;
        private System.Windows.Forms.CheckBox ckbBlackOlives;
        private System.Windows.Forms.CheckBox ckbGreenOlives;
        private System.Windows.Forms.CheckBox ckbBananaPeppers;
        private System.Windows.Forms.CheckBox ckbJalepeno;
        private System.Windows.Forms.CheckBox ckbExtraCheese;
        private System.Windows.Forms.CheckBox ckbMushrooms;
        private System.Windows.Forms.RichTextBox rtfOrderSummary;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

