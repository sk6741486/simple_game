namespace simple_game
{
    partial class s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s));
            this.PICTURESHOW = new System.Windows.Forms.PictureBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.shootaway_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURESHOW)).BeginInit();
            this.SuspendLayout();
            // 
            // PICTURESHOW
            // 
            this.PICTURESHOW.Location = new System.Drawing.Point(39, 12);
            this.PICTURESHOW.Name = "PICTURESHOW";
            this.PICTURESHOW.Size = new System.Drawing.Size(483, 277);
            this.PICTURESHOW.TabIndex = 0;
            this.PICTURESHOW.TabStop = false;
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(39, 310);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(119, 42);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "LOAD";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.Location = new System.Drawing.Point(164, 310);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(110, 42);
            this.spin_btn.TabIndex = 2;
            this.spin_btn.Text = "SPIN";
            this.spin_btn.UseVisualStyleBackColor = true;
            this.spin_btn.Click += new System.EventHandler(this.SPIN_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.Location = new System.Drawing.Point(280, 310);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(120, 42);
            this.shoot_btn.TabIndex = 3;
            this.shoot_btn.Text = "SHOOT";
            this.shoot_btn.UseVisualStyleBackColor = true;
            this.shoot_btn.Click += new System.EventHandler(this.SHOOT_Click);
            // 
            // shootaway_btn
            // 
            this.shootaway_btn.Location = new System.Drawing.Point(406, 310);
            this.shootaway_btn.Name = "shootaway_btn";
            this.shootaway_btn.Size = new System.Drawing.Size(116, 42);
            this.shootaway_btn.TabIndex = 4;
            this.shootaway_btn.Text = "SHOOT AWAY";
            this.shootaway_btn.UseVisualStyleBackColor = true;
            this.shootaway_btn.Click += new System.EventHandler(this.SHOOT_AWAY_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(661, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "PLAY AGAIN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PLAY_AGAIN_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(661, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "EXIT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.shootaway_btn);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.PICTURESHOW);
            this.Name = "s";
            this.Text = "simple_game";
            ((System.ComponentModel.ISupportInitialize)(this.PICTURESHOW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PICTURESHOW;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button shootaway_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

