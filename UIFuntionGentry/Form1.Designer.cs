
namespace UIFuntionGentry
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
            this.VehicalTypeAnswer = new System.Windows.Forms.ComboBox();
            this.RunTheThing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstNameAnswer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LastNameAnswer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VehicalTypeAnswer
            // 
            this.VehicalTypeAnswer.FormattingEnabled = true;
            this.VehicalTypeAnswer.Items.AddRange(new object[] {
            "Car",
            "Sports Car",
            "Truck",
            "Motorcycle",
            "MotorHome"});
            this.VehicalTypeAnswer.Location = new System.Drawing.Point(12, 249);
            this.VehicalTypeAnswer.Name = "VehicalTypeAnswer";
            this.VehicalTypeAnswer.Size = new System.Drawing.Size(121, 23);
            this.VehicalTypeAnswer.TabIndex = 0;
            // 
            // RunTheThing
            // 
            this.RunTheThing.Location = new System.Drawing.Point(248, 231);
            this.RunTheThing.Name = "RunTheThing";
            this.RunTheThing.Size = new System.Drawing.Size(162, 117);
            this.RunTheThing.TabIndex = 1;
            this.RunTheThing.Text = "Submit Order";
            this.RunTheThing.UseVisualStyleBackColor = true;
            this.RunTheThing.Click += new System.EventHandler(this.RunTheThing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to my shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make (string)";
            // 
            // MakeAnswer
            // 
            this.MakeAnswer.Location = new System.Drawing.Point(12, 107);
            this.MakeAnswer.Name = "MakeAnswer";
            this.MakeAnswer.Size = new System.Drawing.Size(100, 23);
            this.MakeAnswer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model (string)";
            // 
            // ModelAnswer
            // 
            this.ModelAnswer.Location = new System.Drawing.Point(11, 152);
            this.ModelAnswer.Name = "ModelAnswer";
            this.ModelAnswer.Size = new System.Drawing.Size(100, 23);
            this.ModelAnswer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year (int)";
            // 
            // YearAnswer
            // 
            this.YearAnswer.Location = new System.Drawing.Point(12, 201);
            this.YearAnswer.Name = "YearAnswer";
            this.YearAnswer.Size = new System.Drawing.Size(100, 23);
            this.YearAnswer.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehicle type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price (double)";
            // 
            // PriceAnswer
            // 
            this.PriceAnswer.Location = new System.Drawing.Point(12, 294);
            this.PriceAnswer.Name = "PriceAnswer";
            this.PriceAnswer.Size = new System.Drawing.Size(100, 23);
            this.PriceAnswer.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "The Vehical";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(248, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "The Buyer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "First Name (string)";
            // 
            // FirstNameAnswer
            // 
            this.FirstNameAnswer.Location = new System.Drawing.Point(248, 107);
            this.FirstNameAnswer.Name = "FirstNameAnswer";
            this.FirstNameAnswer.Size = new System.Drawing.Size(100, 23);
            this.FirstNameAnswer.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Last Name (string)";
            // 
            // LastNameAnswer
            // 
            this.LastNameAnswer.Location = new System.Drawing.Point(248, 156);
            this.LastNameAnswer.Name = "LastNameAnswer";
            this.LastNameAnswer.Size = new System.Drawing.Size(100, 23);
            this.LastNameAnswer.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Email (string)";
            // 
            // EmailAnswer
            // 
            this.EmailAnswer.Location = new System.Drawing.Point(248, 200);
            this.EmailAnswer.Name = "EmailAnswer";
            this.EmailAnswer.Size = new System.Drawing.Size(278, 23);
            this.EmailAnswer.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 356);
            this.Controls.Add(this.EmailAnswer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LastNameAnswer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FirstNameAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YearAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MakeAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunTheThing);
            this.Controls.Add(this.VehicalTypeAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VehicalTypeAnswer;
        private System.Windows.Forms.Button RunTheThing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MakeAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirstNameAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LastNameAnswer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox EmailAnswer;
    }
}

