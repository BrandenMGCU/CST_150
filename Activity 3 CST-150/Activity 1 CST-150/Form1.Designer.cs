namespace Activity_1_CST_150
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
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_fos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_WHYGCU = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Activity 1 for CST-150!";
            // 
            // txtbox_firstname
            // 
            this.txtbox_firstname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_firstname.Location = new System.Drawing.Point(93, 93);
            this.txtbox_firstname.Name = "txtbox_firstname";
            this.txtbox_firstname.Size = new System.Drawing.Size(310, 26);
            this.txtbox_firstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "What is your first name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "What is your field of study:";
            // 
            // txtbox_fos
            // 
            this.txtbox_fos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_fos.Location = new System.Drawing.Point(93, 176);
            this.txtbox_fos.Name = "txtbox_fos";
            this.txtbox_fos.Size = new System.Drawing.Size(310, 26);
            this.txtbox_fos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Why Grand Canyon Univeristy:";
            // 
            // txtbox_WHYGCU
            // 
            this.txtbox_WHYGCU.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbox_WHYGCU.Location = new System.Drawing.Point(93, 255);
            this.txtbox_WHYGCU.Multiline = true;
            this.txtbox_WHYGCU.Name = "txtbox_WHYGCU";
            this.txtbox_WHYGCU.Size = new System.Drawing.Size(310, 83);
            this.txtbox_WHYGCU.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_WHYGCU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_fos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_firstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Activity 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_fos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_WHYGCU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

