namespace ProgPub
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
            this.func1_btn = new System.Windows.Forms.Button();
            this.func2_btn = new System.Windows.Forms.Button();
            this.output_txtbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_txtbox = new System.Windows.Forms.TextBox();
            this.func3_btn = new System.Windows.Forms.Button();
            this.func4_btn = new System.Windows.Forms.Button();
            this.func5_btn = new System.Windows.Forms.Button();
            this.func6_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // func1_btn
            // 
            this.func1_btn.Location = new System.Drawing.Point(12, 86);
            this.func1_btn.Name = "func1_btn";
            this.func1_btn.Size = new System.Drawing.Size(70, 31);
            this.func1_btn.TabIndex = 0;
            this.func1_btn.Text = "Funktion 1";
            this.func1_btn.UseVisualStyleBackColor = true;
            this.func1_btn.Click += new System.EventHandler(this.func1_btn_Click);
            // 
            // func2_btn
            // 
            this.func2_btn.Location = new System.Drawing.Point(12, 123);
            this.func2_btn.Name = "func2_btn";
            this.func2_btn.Size = new System.Drawing.Size(70, 31);
            this.func2_btn.TabIndex = 1;
            this.func2_btn.Text = "Funktion 2";
            this.func2_btn.UseVisualStyleBackColor = true;
            this.func2_btn.Click += new System.EventHandler(this.func2_btn_Click);
            // 
            // output_txtbox
            // 
            this.output_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_txtbox.Location = new System.Drawing.Point(95, 54);
            this.output_txtbox.Name = "output_txtbox";
            this.output_txtbox.Size = new System.Drawing.Size(423, 280);
            this.output_txtbox.TabIndex = 5;
            this.output_txtbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input:";
            // 
            // input_txtbox
            // 
            this.input_txtbox.Location = new System.Drawing.Point(95, 28);
            this.input_txtbox.Name = "input_txtbox";
            this.input_txtbox.Size = new System.Drawing.Size(423, 20);
            this.input_txtbox.TabIndex = 12;
            // 
            // func3_btn
            // 
            this.func3_btn.Location = new System.Drawing.Point(12, 160);
            this.func3_btn.Name = "func3_btn";
            this.func3_btn.Size = new System.Drawing.Size(70, 31);
            this.func3_btn.TabIndex = 13;
            this.func3_btn.Text = "Funktion 3";
            this.func3_btn.UseVisualStyleBackColor = true;
            this.func3_btn.Click += new System.EventHandler(this.func3_btn_Click);
            // 
            // func4_btn
            // 
            this.func4_btn.Location = new System.Drawing.Point(12, 197);
            this.func4_btn.Name = "func4_btn";
            this.func4_btn.Size = new System.Drawing.Size(70, 31);
            this.func4_btn.TabIndex = 14;
            this.func4_btn.Text = "Funktion 4";
            this.func4_btn.UseVisualStyleBackColor = true;
            this.func4_btn.Click += new System.EventHandler(this.func4_btn_Click);
            // 
            // func5_btn
            // 
            this.func5_btn.Location = new System.Drawing.Point(12, 234);
            this.func5_btn.Name = "func5_btn";
            this.func5_btn.Size = new System.Drawing.Size(70, 31);
            this.func5_btn.TabIndex = 15;
            this.func5_btn.Text = "Funktion 5";
            this.func5_btn.UseVisualStyleBackColor = true;
            this.func5_btn.Click += new System.EventHandler(this.func5_btn_Click);
            // 
            // func6_btn
            // 
            this.func6_btn.Location = new System.Drawing.Point(12, 271);
            this.func6_btn.Name = "func6_btn";
            this.func6_btn.Size = new System.Drawing.Size(70, 31);
            this.func6_btn.TabIndex = 16;
            this.func6_btn.Text = "Funktion 6";
            this.func6_btn.UseVisualStyleBackColor = true;
            this.func6_btn.Click += new System.EventHandler(this.func6_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 377);
            this.Controls.Add(this.func6_btn);
            this.Controls.Add(this.func5_btn);
            this.Controls.Add(this.func4_btn);
            this.Controls.Add(this.func3_btn);
            this.Controls.Add(this.input_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_txtbox);
            this.Controls.Add(this.func2_btn);
            this.Controls.Add(this.func1_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button func1_btn;
        private System.Windows.Forms.Button func2_btn;
        private System.Windows.Forms.RichTextBox output_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_txtbox;
        private System.Windows.Forms.Button func3_btn;
        private System.Windows.Forms.Button func4_btn;
        private System.Windows.Forms.Button func5_btn;
        private System.Windows.Forms.Button func6_btn;
    }
}

