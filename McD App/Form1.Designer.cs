
namespace McD_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spnBurger = new System.Windows.Forms.NumericUpDown();
            this.spnChips = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spnNuggets = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.spnDrinks = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNuggets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Burgers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // spnBurger
            // 
            this.spnBurger.Location = new System.Drawing.Point(175, 133);
            this.spnBurger.Name = "spnBurger";
            this.spnBurger.Size = new System.Drawing.Size(37, 23);
            this.spnBurger.TabIndex = 3;
            // 
            // spnChips
            // 
            this.spnChips.Location = new System.Drawing.Point(175, 179);
            this.spnChips.Name = "spnChips";
            this.spnChips.Size = new System.Drawing.Size(37, 23);
            this.spnChips.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chips";
            // 
            // spnNuggets
            // 
            this.spnNuggets.Location = new System.Drawing.Point(175, 223);
            this.spnNuggets.Name = "spnNuggets";
            this.spnNuggets.Size = new System.Drawing.Size(37, 23);
            this.spnNuggets.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nuggets";
            // 
            // spnDrinks
            // 
            this.spnDrinks.Location = new System.Drawing.Point(175, 266);
            this.spnDrinks.Name = "spnDrinks";
            this.spnDrinks.Size = new System.Drawing.Size(37, 23);
            this.spnDrinks.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drinks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "View Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spnDrinks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spnNuggets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spnChips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spnBurger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spnBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNuggets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnBurger;
        private System.Windows.Forms.NumericUpDown spnChips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spnNuggets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spnDrinks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

