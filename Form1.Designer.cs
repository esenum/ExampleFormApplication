namespace ExampleFormApplication_
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
            this.btnPressHere = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelPressHere = new System.Windows.Forms.Label();
            this.labelRPS = new System.Windows.Forms.Label();
            this.labelDYW = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPressHere
            // 
            this.btnPressHere.Location = new System.Drawing.Point(117, 183);
            this.btnPressHere.Name = "btnPressHere";
            this.btnPressHere.Size = new System.Drawing.Size(95, 36);
            this.btnPressHere.TabIndex = 0;
            this.btnPressHere.Text = "Press Here";
            this.btnPressHere.UseVisualStyleBackColor = true;
            this.btnPressHere.Click += new System.EventHandler(this.btnPressHere_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rock Paper Scissor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelPressHere
            // 
            this.labelPressHere.AutoSize = true;
            this.labelPressHere.Location = new System.Drawing.Point(127, 259);
            this.labelPressHere.Name = "labelPressHere";
            this.labelPressHere.Size = new System.Drawing.Size(44, 16);
            this.labelPressHere.TabIndex = 3;
            this.labelPressHere.Text = "label1";
            // 
            // labelRPS
            // 
            this.labelRPS.AutoSize = true;
            this.labelRPS.Location = new System.Drawing.Point(378, 259);
            this.labelRPS.Name = "labelRPS";
            this.labelRPS.Size = new System.Drawing.Size(65, 16);
            this.labelRPS.TabIndex = 4;
            this.labelRPS.Text = "labelRPS";
            // 
            // labelDYW
            // 
            this.labelDYW.AutoSize = true;
            this.labelDYW.Location = new System.Drawing.Point(375, 291);
            this.labelDYW.Name = "labelDYW";
            this.labelDYW.Size = new System.Drawing.Size(69, 16);
            this.labelDYW.TabIndex = 5;
            this.labelDYW.Text = "labelDYW";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(583, 243);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 106);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(595, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(595, 315);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelDYW);
            this.Controls.Add(this.labelRPS);
            this.Controls.Add(this.labelPressHere);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPressHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressHere;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPressHere;
        private System.Windows.Forms.Label labelRPS;
        private System.Windows.Forms.Label labelDYW;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

