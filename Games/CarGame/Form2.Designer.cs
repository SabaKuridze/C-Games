namespace CarGame
{
    partial class ShootingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShootingGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.bullet1timer = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Button();
            this.Exist = new System.Windows.Forms.Button();
            this.EnemyJet3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnemyJet2 = new System.Windows.Forms.PictureBox();
            this.EnemyJet1 = new System.Windows.Forms.PictureBox();
            this.MainJet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainJet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(70, 24);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: ";
            // 
            // bullet1timer
            // 
            this.bullet1timer.Interval = 17;
            this.bullet1timer.Tick += new System.EventHandler(this.bullet1timer_Tick);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Restart.Location = new System.Drawing.Point(153, 236);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(138, 40);
            this.Restart.TabIndex = 31;
            this.Restart.Tag = "3";
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click_1);
            // 
            // Exist
            // 
            this.Exist.BackColor = System.Drawing.Color.Red;
            this.Exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exist.Location = new System.Drawing.Point(153, 294);
            this.Exist.Name = "Exist";
            this.Exist.Size = new System.Drawing.Size(138, 40);
            this.Exist.TabIndex = 32;
            this.Exist.Tag = "3";
            this.Exist.Text = "Close";
            this.Exist.UseVisualStyleBackColor = false;
            this.Exist.Visible = false;
            this.Exist.Click += new System.EventHandler(this.Exist_Click_1);
            // 
            // EnemyJet3
            // 
            this.EnemyJet3.Image = global::CarGame.Properties.Resources.jet_32;
            this.EnemyJet3.Location = new System.Drawing.Point(237, 372);
            this.EnemyJet3.Name = "EnemyJet3";
            this.EnemyJet3.Size = new System.Drawing.Size(54, 70);
            this.EnemyJet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyJet3.TabIndex = 33;
            this.EnemyJet3.TabStop = false;
            this.EnemyJet3.Tag = "2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarGame.Properties.Resources.cloud_1;
            this.pictureBox4.Location = new System.Drawing.Point(103, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox3.Image = global::CarGame.Properties.Resources.cloud_1;
            this.pictureBox3.Location = new System.Drawing.Point(308, 465);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarGame.Properties.Resources.cloud_1;
            this.pictureBox2.Location = new System.Drawing.Point(19, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarGame.Properties.Resources.bullet_1;
            this.pictureBox1.Location = new System.Drawing.Point(212, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "2";
            this.pictureBox1.Visible = false;
            // 
            // EnemyJet2
            // 
            this.EnemyJet2.Image = global::CarGame.Properties.Resources.jet_32;
            this.EnemyJet2.Location = new System.Drawing.Point(354, 95);
            this.EnemyJet2.Name = "EnemyJet2";
            this.EnemyJet2.Size = new System.Drawing.Size(54, 70);
            this.EnemyJet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyJet2.TabIndex = 2;
            this.EnemyJet2.TabStop = false;
            this.EnemyJet2.Tag = "2";
            // 
            // EnemyJet1
            // 
            this.EnemyJet1.Image = global::CarGame.Properties.Resources.jet_32;
            this.EnemyJet1.Location = new System.Drawing.Point(45, 206);
            this.EnemyJet1.Name = "EnemyJet1";
            this.EnemyJet1.Size = new System.Drawing.Size(54, 70);
            this.EnemyJet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyJet1.TabIndex = 1;
            this.EnemyJet1.TabStop = false;
            this.EnemyJet1.Tag = "2";
            // 
            // MainJet
            // 
            this.MainJet.Image = global::CarGame.Properties.Resources.jet_8;
            this.MainJet.Location = new System.Drawing.Point(174, 551);
            this.MainJet.Name = "MainJet";
            this.MainJet.Size = new System.Drawing.Size(91, 107);
            this.MainJet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainJet.TabIndex = 0;
            this.MainJet.TabStop = false;
            this.MainJet.Tag = "2";
            this.MainJet.Click += new System.EventHandler(this.MainJet_Click);
            // 
            // ShootingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.EnemyJet3);
            this.Controls.Add(this.Exist);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.EnemyJet2);
            this.Controls.Add(this.EnemyJet1);
            this.Controls.Add(this.MainJet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ShootingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Jet Game";
            this.Load += new System.EventHandler(this.ShootingGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShootingGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyJet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainJet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainJet;
        private System.Windows.Forms.PictureBox EnemyJet1;
        private System.Windows.Forms.PictureBox EnemyJet2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer bullet1timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Exist;
        private System.Windows.Forms.PictureBox EnemyJet3;
    }
}