
namespace rockpaperscissors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.brnScissor = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.picPlayerIconBox = new System.Windows.Forms.PictureBox();
            this.picCpuIconBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.ForeColor = System.Drawing.Color.Black;
            this.btnRock.Location = new System.Drawing.Point(24, 199);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(150, 88);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.ForeColor = System.Drawing.Color.Black;
            this.btnPaper.Location = new System.Drawing.Point(412, 199);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(150, 88);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // brnScissor
            // 
            this.brnScissor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnScissor.BackgroundImage")));
            this.brnScissor.ForeColor = System.Drawing.Color.Black;
            this.brnScissor.Location = new System.Drawing.Point(227, 199);
            this.brnScissor.Name = "brnScissor";
            this.brnScissor.Size = new System.Drawing.Size(150, 88);
            this.brnScissor.TabIndex = 2;
            this.brnScissor.Text = "Scissor";
            this.brnScissor.UseVisualStyleBackColor = true;
            this.brnScissor.Click += new System.EventHandler(this.brnScissor_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(632, 513);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 88);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1009, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Gold;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(462, 72);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(406, 52);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Player: 0  - CPU: 0";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Gold;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(641, 167);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(43, 46);
            this.lblCountdown.TabIndex = 10;
            this.lblCountdown.Text = "5";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Gold;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.Location = new System.Drawing.Point(556, 250);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(202, 46);
            this.lblRoundNumber.TabIndex = 11;
            this.lblRoundNumber.Text = "Round : 3";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // picPlayerIconBox
            // 
            this.picPlayerIconBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picPlayerIconBox.Image = global::rockpaperscissors.Properties.Resources.question;
            this.picPlayerIconBox.Location = new System.Drawing.Point(151, 43);
            this.picPlayerIconBox.Name = "picPlayerIconBox";
            this.picPlayerIconBox.Size = new System.Drawing.Size(257, 253);
            this.picPlayerIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerIconBox.TabIndex = 6;
            this.picPlayerIconBox.TabStop = false;
            // 
            // picCpuIconBox
            // 
            this.picCpuIconBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picCpuIconBox.Image = global::rockpaperscissors.Properties.Resources.question;
            this.picCpuIconBox.Location = new System.Drawing.Point(885, 43);
            this.picCpuIconBox.Name = "picCpuIconBox";
            this.picCpuIconBox.Size = new System.Drawing.Size(257, 253);
            this.picCpuIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuIconBox.TabIndex = 4;
            this.picCpuIconBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnPaper);
            this.groupBox1.Controls.Add(this.btnRock);
            this.groupBox1.Controls.Add(this.brnScissor);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 371);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Choice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1154, 653);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlayerIconBox);
            this.Controls.Add(this.picCpuIconBox);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button brnScissor;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picCpuIconBox;
        private System.Windows.Forms.PictureBox picPlayerIconBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

