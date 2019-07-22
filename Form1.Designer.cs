namespace game_1
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllooses = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblshots = new System.Windows.Forms.Label();
            this.lbllivs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Load.Location = new System.Drawing.Point(21, 1);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 48);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Spin.Location = new System.Drawing.Point(6, 55);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(94, 56);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Shoot.Location = new System.Drawing.Point(6, 133);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(94, 55);
            this.btn_Shoot.TabIndex = 2;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShootAway.Location = new System.Drawing.Point(6, 219);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(94, 52);
            this.btn_ShootAway.TabIndex = 3;
            this.btn_ShootAway.Text = "Shoot Away";
            this.btn_ShootAway.UseVisualStyleBackColor = false;
            this.btn_ShootAway.Click += new System.EventHandler(this.Btn_ShootAway_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PlayAgain.Location = new System.Drawing.Point(12, 387);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(94, 51);
            this.btn_PlayAgain.TabIndex = 4;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(609, 398);
            this.btn_Exit.MaximumSize = new System.Drawing.Size(1, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(1, 1);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 167);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(550, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(644, 387);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 38);
            this.exit.TabIndex = 8;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(195, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(192, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loose";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllooses
            // 
            this.lbllooses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllooses.Location = new System.Drawing.Point(294, 325);
            this.lbllooses.Name = "lbllooses";
            this.lbllooses.Size = new System.Drawing.Size(62, 36);
            this.lbllooses.TabIndex = 11;
            this.lbllooses.Text = "label3";
            this.lbllooses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwin
            // 
            this.lblwin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblwin.Location = new System.Drawing.Point(291, 265);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(65, 46);
            this.lblwin.TabIndex = 12;
            this.lblwin.Text = "label4";
            this.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(471, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Shoot away";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(471, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "shoot";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblshots
            // 
            this.lblshots.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblshots.Location = new System.Drawing.Point(606, 265);
            this.lblshots.Name = "lblshots";
            this.lblshots.Size = new System.Drawing.Size(56, 38);
            this.lblshots.TabIndex = 15;
            this.lblshots.Text = "lbl";
            this.lblshots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllivs
            // 
            this.lbllivs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllivs.Location = new System.Drawing.Point(606, 325);
            this.lbllivs.Name = "lbllivs";
            this.lbllivs.Size = new System.Drawing.Size(47, 36);
            this.lbllivs.TabIndex = 16;
            this.lbllivs.Text = "lbl";
            this.lbllivs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbllivs);
            this.Controls.Add(this.lblshots);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.lbllooses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Load);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_ShootAway;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllooses;
        private System.Windows.Forms.Label lblwin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblshots;
        private System.Windows.Forms.Label lbllivs;
        private System.Windows.Forms.Label label7;

        public int Roulette11 { get; private set; }
    }
}

