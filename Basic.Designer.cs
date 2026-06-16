namespace MeCalc
{
    partial class Basic
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
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Calculator = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.perc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(34, 148);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(57, 24);
            this.Value1.TabIndex = 0;
            this.Value1.Text = "Value1";
            this.Value1.UseCompatibleTextRendering = true;
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(32, 221);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(59, 20);
            this.Value2.TabIndex = 1;
            this.Value2.Text = "Value2";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(32, 281);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(58, 20);
            this.Output.TabIndex = 2;
            this.Output.Text = "Output";
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calculator.Location = new System.Drawing.Point(61, 9);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(341, 78);
            this.Calculator.TabIndex = 3;
            this.Calculator.Text = "Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 26);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(55, 360);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(35, 35);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(121, 360);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(35, 35);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(193, 360);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(35, 35);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(266, 360);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(35, 35);
            this.mult.TabIndex = 10;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // perc
            // 
            this.perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perc.Location = new System.Drawing.Point(336, 360);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(35, 35);
            this.perc.TabIndex = 11;
            this.perc.Text = "%";
            this.perc.UseVisualStyleBackColor = true;
            this.perc.Click += new System.EventHandler(this.perc_Click);
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Name = "Basic";
            this.Text = "BasicCal";
            this.Load += new System.EventHandler(this.Basic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button perc;
    }
}

