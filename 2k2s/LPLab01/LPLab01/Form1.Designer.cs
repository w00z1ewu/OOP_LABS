
namespace LPLab01
{
    partial class Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_saveResult = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.operation_label = new System.Windows.Forms.Label();
            this.button_getRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 0;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(383, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "CLR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(209, 69);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(81, 49);
            this.button_mod.TabIndex = 4;
            this.button_mod.Text = "mod";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(315, 69);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(81, 49);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(315, 138);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(81, 49);
            this.button_minus.TabIndex = 9;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(209, 138);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(81, 49);
            this.button_9.TabIndex = 8;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            //this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(108, 138);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(81, 49);
            this.button_8.TabIndex = 7;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            //this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(11, 138);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(81, 49);
            this.button_7.TabIndex = 6;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            //this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(315, 211);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(81, 49);
            this.button_multiply.TabIndex = 13;
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(209, 211);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(81, 49);
            this.button_6.TabIndex = 12;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            //this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(108, 211);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(81, 49);
            this.button_5.TabIndex = 11;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            //this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(11, 211);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(81, 49);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            //this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(315, 284);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(81, 49);
            this.button_division.TabIndex = 17;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(209, 284);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(81, 49);
            this.button_3.TabIndex = 16;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            //this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(108, 284);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(81, 49);
            this.button_2.TabIndex = 15;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            //this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(11, 284);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(81, 49);
            this.button_1.TabIndex = 14;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            //this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(315, 354);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(81, 49);
            this.button_submit.TabIndex = 21;
            this.button_submit.Text = "=";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_saveResult
            // 
            this.button_saveResult.Location = new System.Drawing.Point(108, 354);
            this.button_saveResult.Name = "button_saveResult";
            this.button_saveResult.Size = new System.Drawing.Size(81, 49);
            this.button_saveResult.TabIndex = 19;
            this.button_saveResult.Text = "save";
            this.button_saveResult.UseVisualStyleBackColor = true;
            this.button_saveResult.Click += new System.EventHandler(this.button_saveResult_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(11, 354);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(81, 49);
            this.button_0.TabIndex = 18;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            //this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // operation_label
            // 
            this.operation_label.AutoSize = true;
            this.operation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_label.Location = new System.Drawing.Point(13, 15);
            this.operation_label.Name = "operation_label";
            this.operation_label.Size = new System.Drawing.Size(0, 29);
            this.operation_label.TabIndex = 22;
            this.operation_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_getRes
            // 
            this.button_getRes.Location = new System.Drawing.Point(209, 354);
            this.button_getRes.Name = "button_getRes";
            this.button_getRes.Size = new System.Drawing.Size(81, 49);
            this.button_getRes.TabIndex = 23;
            this.button_getRes.Text = "get";
            this.button_getRes.UseVisualStyleBackColor = true;
            this.button_getRes.Click += new System.EventHandler(this.button_getRes_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 422);
            this.Controls.Add(this.button_getRes);
            this.Controls.Add(this.operation_label);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_saveResult);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "ApoloCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_saveResult;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Label operation_label;
        private System.Windows.Forms.Button button_getRes;
    }
}

