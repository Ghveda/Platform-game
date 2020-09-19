namespace PlatformGame
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
            this.Ninja = new System.Windows.Forms.PictureBox();
            this.brick = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.brick4 = new System.Windows.Forms.PictureBox();
            this.brick5 = new System.Windows.Forms.PictureBox();
            this.brick6 = new System.Windows.Forms.PictureBox();
            this.mainlove = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.GroupBox();
            this.restartgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ninja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            this.finish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ninja
            // 
            this.Ninja.BackColor = System.Drawing.Color.Transparent;
            this.Ninja.Image = ((System.Drawing.Image)(resources.GetObject("Ninja.Image")));
            this.Ninja.Location = new System.Drawing.Point(0, 414);
            this.Ninja.Name = "Ninja";
            this.Ninja.Size = new System.Drawing.Size(43, 46);
            this.Ninja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ninja.TabIndex = 0;
            this.Ninja.TabStop = false;
            // 
            // brick
            // 
            this.brick.BackColor = System.Drawing.Color.Transparent;
            this.brick.Image = ((System.Drawing.Image)(resources.GetObject("brick.Image")));
            this.brick.Location = new System.Drawing.Point(192, 414);
            this.brick.Name = "brick";
            this.brick.Size = new System.Drawing.Size(70, 32);
            this.brick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick.TabIndex = 1;
            this.brick.TabStop = false;
            this.brick.Tag = "platform";
            this.brick.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Transparent;
            this.brick2.Image = ((System.Drawing.Image)(resources.GetObject("brick2.Image")));
            this.brick2.Location = new System.Drawing.Point(12, 349);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(70, 32);
            this.brick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick2.TabIndex = 1;
            this.brick2.TabStop = false;
            this.brick2.Tag = "platform";
            this.brick2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Transparent;
            this.brick3.Image = ((System.Drawing.Image)(resources.GetObject("brick3.Image")));
            this.brick3.Location = new System.Drawing.Point(192, 275);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(70, 32);
            this.brick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick3.TabIndex = 1;
            this.brick3.TabStop = false;
            this.brick3.Tag = "platform";
            this.brick3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Transparent;
            this.brick4.Image = ((System.Drawing.Image)(resources.GetObject("brick4.Image")));
            this.brick4.Location = new System.Drawing.Point(12, 210);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(70, 32);
            this.brick4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick4.TabIndex = 1;
            this.brick4.TabStop = false;
            this.brick4.Tag = "platform";
            this.brick4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.Transparent;
            this.brick5.Image = ((System.Drawing.Image)(resources.GetObject("brick5.Image")));
            this.brick5.Location = new System.Drawing.Point(192, 130);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(70, 32);
            this.brick5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick5.TabIndex = 1;
            this.brick5.TabStop = false;
            this.brick5.Tag = "platform";
            this.brick5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // brick6
            // 
            this.brick6.BackColor = System.Drawing.Color.Transparent;
            this.brick6.Image = ((System.Drawing.Image)(resources.GetObject("brick6.Image")));
            this.brick6.Location = new System.Drawing.Point(12, 56);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(70, 32);
            this.brick6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick6.TabIndex = 1;
            this.brick6.TabStop = false;
            this.brick6.Tag = "platform";
            this.brick6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainlove
            // 
            this.mainlove.BackColor = System.Drawing.Color.Transparent;
            this.mainlove.Image = ((System.Drawing.Image)(resources.GetObject("mainlove.Image")));
            this.mainlove.Location = new System.Drawing.Point(12, 27);
            this.mainlove.Name = "mainlove";
            this.mainlove.Size = new System.Drawing.Size(39, 32);
            this.mainlove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainlove.TabIndex = 2;
            this.mainlove.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.MainTimer);
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(208, 380);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(39, 28);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 3;
            this.coin1.TabStop = false;
            this.coin1.Tag = "Coin";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(28, 315);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(39, 28);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 3;
            this.coin2.TabStop = false;
            this.coin2.Tag = "Coin";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(208, 241);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(39, 28);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 3;
            this.coin3.TabStop = false;
            this.coin3.Tag = "Coin";
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(28, 176);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(39, 28);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 3;
            this.coin4.TabStop = false;
            this.coin4.Tag = "Coin";
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.Color.Transparent;
            this.coin5.Image = ((System.Drawing.Image)(resources.GetObject("coin5.Image")));
            this.coin5.Location = new System.Drawing.Point(208, 96);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(39, 28);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin5.TabIndex = 3;
            this.coin5.TabStop = false;
            this.coin5.Tag = "Coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coins: 0";
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.Transparent;
            this.finish.Controls.Add(this.restartgame);
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.Location = new System.Drawing.Point(73, 110);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(155, 94);
            this.finish.TabIndex = 5;
            this.finish.TabStop = false;
            this.finish.Text = "You are winner!!";
            // 
            // restartgame
            // 
            this.restartgame.Location = new System.Drawing.Point(42, 66);
            this.restartgame.Name = "restartgame";
            this.restartgame.Size = new System.Drawing.Size(75, 23);
            this.restartgame.TabIndex = 0;
            this.restartgame.Text = "Restart";
            this.restartgame.UseVisualStyleBackColor = true;
            this.restartgame.Click += new System.EventHandler(this.restartgame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(288, 460);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.mainlove);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick);
            this.Controls.Add(this.Ninja);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ninja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainlove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            this.finish.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ninja;
        private System.Windows.Forms.PictureBox brick;
        private System.Windows.Forms.PictureBox brick2;
        private System.Windows.Forms.PictureBox brick3;
        private System.Windows.Forms.PictureBox brick4;
        private System.Windows.Forms.PictureBox brick5;
        private System.Windows.Forms.PictureBox brick6;
        private System.Windows.Forms.PictureBox mainlove;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox finish;
        private System.Windows.Forms.Button restartgame;
    }
}

