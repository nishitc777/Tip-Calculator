
namespace Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Number_Of_People = new System.Windows.Forms.NumericUpDown();
            this.Tip_Amount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_Per_Person = new System.Windows.Forms.Label();
            this.Tip_Per_Person = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Get_Output_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Of_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_Amount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // Bill_Amount
            // 
            this.Bill_Amount.Location = new System.Drawing.Point(0, 64);
            this.Bill_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Bill_Amount.Name = "Bill_Amount";
            this.Bill_Amount.Size = new System.Drawing.Size(250, 26);
            this.Bill_Amount.TabIndex = 1;
            this.Bill_Amount.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Number_Of_People);
            this.groupBox1.Controls.Add(this.Tip_Amount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bill_Amount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 246);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Number_Of_People
            // 
            this.Number_Of_People.Location = new System.Drawing.Point(0, 203);
            this.Number_Of_People.Margin = new System.Windows.Forms.Padding(4);
            this.Number_Of_People.Name = "Number_Of_People";
            this.Number_Of_People.Size = new System.Drawing.Size(250, 26);
            this.Number_Of_People.TabIndex = 6;
            // 
            // Tip_Amount
            // 
            this.Tip_Amount.Location = new System.Drawing.Point(0, 133);
            this.Tip_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Tip_Amount.Name = "Tip_Amount";
            this.Tip_Amount.Size = new System.Drawing.Size(250, 26);
            this.Tip_Amount.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Total_Per_Person);
            this.groupBox2.Controls.Add(this.Tip_Per_Person);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(467, 246);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "$";
            // 
            // Total_Per_Person
            // 
            this.Total_Per_Person.AutoSize = true;
            this.Total_Per_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Per_Person.Location = new System.Drawing.Point(111, 178);
            this.Total_Per_Person.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_Per_Person.Name = "Total_Per_Person";
            this.Total_Per_Person.Size = new System.Drawing.Size(87, 39);
            this.Total_Per_Person.TabIndex = 5;
            this.Total_Per_Person.Text = "0.00";
            // 
            // Tip_Per_Person
            // 
            this.Tip_Per_Person.AutoSize = true;
            this.Tip_Per_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Per_Person.Location = new System.Drawing.Point(111, 93);
            this.Tip_Per_Person.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tip_Per_Person.Name = "Tip_Per_Person";
            this.Tip_Per_Person.Size = new System.Drawing.Size(83, 39);
            this.Tip_Per_Person.TabIndex = 4;
            this.Tip_Per_Person.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total (per person):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tip (per person):";
            // 
            // Get_Output_Button
            // 
            this.Get_Output_Button.Location = new System.Drawing.Point(313, 383);
            this.Get_Output_Button.Name = "Get_Output_Button";
            this.Get_Output_Button.Size = new System.Drawing.Size(100, 40);
            this.Get_Output_Button.TabIndex = 8;
            this.Get_Output_Button.Text = "Get Output";
            this.Get_Output_Button.UseVisualStyleBackColor = true;
            this.Get_Output_Button.Click += new System.EventHandler(this.GetFinalOutput);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(221, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 48);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tip Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Get_Output_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tip Calculator Assignment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Of_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_Amount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bill_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Number_Of_People;
        private System.Windows.Forms.NumericUpDown Tip_Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Tip_Per_Person;
        private System.Windows.Forms.Label Total_Per_Person;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Get_Output_Button;
        private System.Windows.Forms.Label label10;
    }
}

