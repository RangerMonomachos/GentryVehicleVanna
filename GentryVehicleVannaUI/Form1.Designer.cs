
namespace GentryVehicleVannaUI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VehicleTypeAnswer = new System.Windows.Forms.ComboBox();
            this.RunTheThing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // VehicleTypeAnswer
            // 
            this.VehicleTypeAnswer.FormattingEnabled = true;
            this.VehicleTypeAnswer.Items.AddRange(new object[] {
            "Car",
            "Sports Car",
            "Truck",
            "Motorcycle",
            "MotorHome"});
            this.VehicleTypeAnswer.Location = new System.Drawing.Point(13, 134);
            this.VehicleTypeAnswer.Name = "VehicleTypeAnswer";
            this.VehicleTypeAnswer.Size = new System.Drawing.Size(121, 21);
            this.VehicleTypeAnswer.TabIndex = 1;
            // 
            // RunTheThing
            // 
            this.RunTheThing.Location = new System.Drawing.Point(280, 239);
            this.RunTheThing.Name = "RunTheThing";
            this.RunTheThing.Size = new System.Drawing.Size(75, 23);
            this.RunTheThing.TabIndex = 2;
            this.RunTheThing.Text = "button1";
            this.RunTheThing.UseVisualStyleBackColor = true;
            this.RunTheThing.Click += new System.EventHandler(this.RunTheThing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunTheThing);
            this.Controls.Add(this.VehicleTypeAnswer);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox VehicleTypeAnswer;
        private System.Windows.Forms.Button RunTheThing;
    }
}

