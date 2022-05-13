namespace Activity_8_CST_150
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FatCalories = new System.Windows.Forms.TextBox();
            this.CarbCalories = new System.Windows.Forms.TextBox();
            this.CalorieTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your fat calorie count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please enter your carb calorie count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your total consumed calories are:";
            // 
            // FatCalories
            // 
            this.FatCalories.Location = new System.Drawing.Point(627, 77);
            this.FatCalories.Multiline = true;
            this.FatCalories.Name = "FatCalories";
            this.FatCalories.Size = new System.Drawing.Size(263, 37);
            this.FatCalories.TabIndex = 7;
            this.FatCalories.TextChanged += new System.EventHandler(this.FatCalories_TextChanged);
            // 
            // CarbCalories
            // 
            this.CarbCalories.Location = new System.Drawing.Point(627, 203);
            this.CarbCalories.Multiline = true;
            this.CarbCalories.Name = "CarbCalories";
            this.CarbCalories.Size = new System.Drawing.Size(263, 37);
            this.CarbCalories.TabIndex = 8;
            this.CarbCalories.TextChanged += new System.EventHandler(this.CarbCalories_TextChanged);
            // 
            // CalorieTotal
            // 
            this.CalorieTotal.BackColor = System.Drawing.SystemColors.Window;
            this.CalorieTotal.Location = new System.Drawing.Point(627, 310);
            this.CalorieTotal.Multiline = true;
            this.CalorieTotal.Name = "CalorieTotal";
            this.CalorieTotal.ReadOnly = true;
            this.CalorieTotal.Size = new System.Drawing.Size(263, 193);
            this.CalorieTotal.TabIndex = 9;
            this.CalorieTotal.TextChanged += new System.EventHandler(this.CalorieTotal_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 87);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate my Calories!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(907, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalorieTotal);
            this.Controls.Add(this.CarbCalories);
            this.Controls.Add(this.FatCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calorie Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FatCalories;
        private System.Windows.Forms.TextBox CarbCalories;
        private System.Windows.Forms.TextBox CalorieTotal;
        private System.Windows.Forms.Button button1;
    }
}

