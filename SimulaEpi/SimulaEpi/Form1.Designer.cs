namespace SimulaEpi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.initialize = new System.Windows.Forms.Button();
            this.lambda = new System.Windows.Forms.Button();
            this.transmissionprob = new System.Windows.Forms.Button();
            this.infect = new System.Windows.Forms.Button();
            this.vaccine = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.latent = new System.Windows.Forms.Button();
            this.infectious = new System.Windows.Forms.Button();
            this.recovery = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkScheduling = new System.Windows.Forms.CheckBox();
            this.noSchedulingOp = new System.Windows.Forms.TextBox();
            this.perVacScheduling = new System.Windows.Forms.TextBox();
            this.radioTrigger = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.getFromFileBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.saveConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 562);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // initialize
            // 
            this.initialize.Location = new System.Drawing.Point(12, 585);
            this.initialize.Name = "initialize";
            this.initialize.Size = new System.Drawing.Size(163, 41);
            this.initialize.TabIndex = 2;
            this.initialize.Text = "Initialize";
            this.initialize.UseVisualStyleBackColor = true;
            this.initialize.Click += new System.EventHandler(this.button2_Click);
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(595, 72);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(163, 26);
            this.lambda.TabIndex = 5;
            this.lambda.Text = "Contact Rate";
            this.lambda.UseVisualStyleBackColor = true;
            this.lambda.Click += new System.EventHandler(this.lambda_Click);
            // 
            // transmissionprob
            // 
            this.transmissionprob.Location = new System.Drawing.Point(595, 104);
            this.transmissionprob.Name = "transmissionprob";
            this.transmissionprob.Size = new System.Drawing.Size(163, 24);
            this.transmissionprob.TabIndex = 6;
            this.transmissionprob.Text = "Transmision Prob.";
            this.transmissionprob.UseVisualStyleBackColor = true;
            this.transmissionprob.Click += new System.EventHandler(this.transmissionprob_Click);
            // 
            // infect
            // 
            this.infect.Location = new System.Drawing.Point(599, 192);
            this.infect.Name = "infect";
            this.infect.Size = new System.Drawing.Size(159, 24);
            this.infect.TabIndex = 8;
            this.infect.Text = "Random Infect";
            this.infect.UseVisualStyleBackColor = true;
            this.infect.Click += new System.EventHandler(this.infect_Click);
            // 
            // vaccine
            // 
            this.vaccine.Location = new System.Drawing.Point(599, 222);
            this.vaccine.Name = "vaccine";
            this.vaccine.Size = new System.Drawing.Size(160, 24);
            this.vaccine.TabIndex = 9;
            this.vaccine.Text = "Random Vaccine";
            this.vaccine.UseVisualStyleBackColor = true;
            this.vaccine.Click += new System.EventHandler(this.vaccine_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(597, 251);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(162, 25);
            this.remove.TabIndex = 10;
            this.remove.Text = "Random Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // latent
            // 
            this.latent.Location = new System.Drawing.Point(597, 283);
            this.latent.Name = "latent";
            this.latent.Size = new System.Drawing.Size(161, 23);
            this.latent.TabIndex = 13;
            this.latent.Text = "Latent Period";
            this.latent.UseVisualStyleBackColor = true;
            this.latent.Click += new System.EventHandler(this.latent_Click);
            // 
            // infectious
            // 
            this.infectious.Location = new System.Drawing.Point(599, 312);
            this.infectious.Name = "infectious";
            this.infectious.Size = new System.Drawing.Size(160, 23);
            this.infectious.TabIndex = 14;
            this.infectious.Text = "Infectious Period";
            this.infectious.UseVisualStyleBackColor = true;
            this.infectious.Click += new System.EventHandler(this.infectious_Click);
            // 
            // recovery
            // 
            this.recovery.Location = new System.Drawing.Point(599, 341);
            this.recovery.Name = "recovery";
            this.recovery.Size = new System.Drawing.Size(160, 23);
            this.recovery.TabIndex = 15;
            this.recovery.Text = "Recovery Period";
            this.recovery.UseVisualStyleBackColor = true;
            this.recovery.Click += new System.EventHandler(this.recovery_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(194, 584);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(158, 41);
            this.update.TabIndex = 16;
            this.update.Text = "Run Step by Step";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(915, 584);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(51, 40);
            this.quit.TabIndex = 17;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(794, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Statistics";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SEIRS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SEIR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(776, 199);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 17);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Target Infect";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(776, 229);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 17);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Target Vaccine";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(776, 259);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(99, 17);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Target Remove";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(595, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 54);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(598, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Config.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ploting Tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "Seed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(367, 584);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(97, 41);
            this.go.TabIndex = 28;
            this.go.Text = "Go.";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(470, 584);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 41);
            this.pause.TabIndex = 29;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 30;
            this.button3.Text = "Export Img";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkScheduling);
            this.groupBox2.Controls.Add(this.noSchedulingOp);
            this.groupBox2.Controls.Add(this.perVacScheduling);
            this.groupBox2.Controls.Add(this.radioTrigger);
            this.groupBox2.Controls.Add(this.radioTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(766, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scheduling Vaccination";
            // 
            // checkScheduling
            // 
            this.checkScheduling.AutoSize = true;
            this.checkScheduling.Location = new System.Drawing.Point(9, 18);
            this.checkScheduling.Name = "checkScheduling";
            this.checkScheduling.Size = new System.Drawing.Size(171, 17);
            this.checkScheduling.TabIndex = 5;
            this.checkScheduling.Text = "Active Scheduling Vaccination";
            this.checkScheduling.UseVisualStyleBackColor = true;
            this.checkScheduling.CheckedChanged += new System.EventHandler(this.checkScheduling_CheckedChanged);
            // 
            // noSchedulingOp
            // 
            this.noSchedulingOp.Location = new System.Drawing.Point(70, 106);
            this.noSchedulingOp.Name = "noSchedulingOp";
            this.noSchedulingOp.Size = new System.Drawing.Size(100, 20);
            this.noSchedulingOp.TabIndex = 4;
            // 
            // perVacScheduling
            // 
            this.perVacScheduling.Location = new System.Drawing.Point(70, 54);
            this.perVacScheduling.Name = "perVacScheduling";
            this.perVacScheduling.Size = new System.Drawing.Size(100, 20);
            this.perVacScheduling.TabIndex = 3;
            // 
            // radioTrigger
            // 
            this.radioTrigger.AutoSize = true;
            this.radioTrigger.Location = new System.Drawing.Point(67, 80);
            this.radioTrigger.Name = "radioTrigger";
            this.radioTrigger.Size = new System.Drawing.Size(54, 17);
            this.radioTrigger.TabIndex = 2;
            this.radioTrigger.TabStop = true;
            this.radioTrigger.Text = "trigger";
            this.radioTrigger.UseVisualStyleBackColor = true;
            this.radioTrigger.CheckedChanged += new System.EventHandler(this.radioTrigger_CheckedChanged);
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(9, 80);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(44, 17);
            this.radioTime.TabIndex = 1;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "time";
            this.radioTime.UseVisualStyleBackColor = true;
            this.radioTime.CheckedChanged += new System.EventHandler(this.radioTime_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount of vaccine";
            // 
            // getFromFileBtn
            // 
            this.getFromFileBtn.Location = new System.Drawing.Point(775, 329);
            this.getFromFileBtn.Name = "getFromFileBtn";
            this.getFromFileBtn.Size = new System.Drawing.Size(191, 35);
            this.getFromFileBtn.TabIndex = 32;
            this.getFromFileBtn.Text = "Get Parameters from Xml File";
            this.getFromFileBtn.UseVisualStyleBackColor = true;
            this.getFromFileBtn.Click += new System.EventHandler(this.getFromFileBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(834, 584);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 33;
            this.button5.Text = "About";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // saveConf
            // 
            this.saveConf.Location = new System.Drawing.Point(775, 282);
            this.saveConf.Name = "saveConf";
            this.saveConf.Size = new System.Drawing.Size(191, 41);
            this.saveConf.TabIndex = 35;
            this.saveConf.Text = "Save Configuration Parameters";
            this.saveConf.UseVisualStyleBackColor = true;
            this.saveConf.Click += new System.EventHandler(this.saveConf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 638);
            this.Controls.Add(this.saveConf);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.getFromFileBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.go);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.recovery);
            this.Controls.Add(this.infectious);
            this.Controls.Add(this.latent);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.vaccine);
            this.Controls.Add(this.infect);
            this.Controls.Add(this.transmissionprob);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.initialize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cellular Automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button initialize;
        private System.Windows.Forms.Button lambda;
        private System.Windows.Forms.Button transmissionprob;
        private System.Windows.Forms.Button infect;
        private System.Windows.Forms.Button vaccine;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button latent;
        private System.Windows.Forms.Button infectious;
        private System.Windows.Forms.Button recovery;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button pause;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTrigger;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkScheduling;
        private System.Windows.Forms.TextBox noSchedulingOp;
        private System.Windows.Forms.TextBox perVacScheduling;
        private System.Windows.Forms.Button getFromFileBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button saveConf;
    }
}

