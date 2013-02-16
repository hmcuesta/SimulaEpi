namespace SimulaEpi
{
    partial class InputWindow
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(37, 29);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(49, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "_______";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(131, 97);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(75, 23);
            this.inputBtn.TabIndex = 3;
            this.inputBtn.Text = "OK..";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 146);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInput);
            this.Name = "InputWindow";
            this.Text = "InputWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button inputBtn;
    }
}