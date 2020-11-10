namespace CompleteAssement1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShootingButtornFaraway = new System.Windows.Forms.Button();
            this.GunReloadButton = new System.Windows.Forms.Button();
            this.SwitchGunButton = new System.Windows.Forms.Button();
            this.GunFiringButton = new System.Windows.Forms.Button();
            this.Backgroundofgame = new System.Windows.Forms.PictureBox();
            this.TryitagainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Backgroundofgame)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootingButtornFaraway
            // 
            this.ShootingButtornFaraway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ShootingButtornFaraway.Location = new System.Drawing.Point(514, 12);
            this.ShootingButtornFaraway.Name = "ShootingButtornFaraway";
            this.ShootingButtornFaraway.Size = new System.Drawing.Size(181, 48);
            this.ShootingButtornFaraway.TabIndex = 2;
            this.ShootingButtornFaraway.Text = "Far Shooting";
            this.ShootingButtornFaraway.UseVisualStyleBackColor = false;
            this.ShootingButtornFaraway.Click += new System.EventHandler(this.ShootAwayBt_Click);
            // 
            // GunReloadButton
            // 
            this.GunReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GunReloadButton.Location = new System.Drawing.Point(501, 364);
            this.GunReloadButton.Name = "GunReloadButton";
            this.GunReloadButton.Size = new System.Drawing.Size(194, 54);
            this.GunReloadButton.TabIndex = 5;
            this.GunReloadButton.Text = "Load Your Gun";
            this.GunReloadButton.UseVisualStyleBackColor = false;
            this.GunReloadButton.Click += new System.EventHandler(this.LoadBt_Click);
            // 
            // SwitchGunButton
            // 
            this.SwitchGunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SwitchGunButton.Location = new System.Drawing.Point(295, 12);
            this.SwitchGunButton.Name = "SwitchGunButton";
            this.SwitchGunButton.Size = new System.Drawing.Size(131, 48);
            this.SwitchGunButton.TabIndex = 6;
            this.SwitchGunButton.Text = "Switch Gun";
            this.SwitchGunButton.UseVisualStyleBackColor = false;
            this.SwitchGunButton.Click += new System.EventHandler(this.SpinBt_Click);
            // 
            // GunFiringButton
            // 
            this.GunFiringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GunFiringButton.Location = new System.Drawing.Point(226, 320);
            this.GunFiringButton.Name = "GunFiringButton";
            this.GunFiringButton.Size = new System.Drawing.Size(130, 59);
            this.GunFiringButton.TabIndex = 1;
            this.GunFiringButton.Text = "Shoot Gun";
            this.GunFiringButton.UseVisualStyleBackColor = false;
            this.GunFiringButton.Click += new System.EventHandler(this.GunShootBt_Click);
            // 
            // Backgroundofgame
            // 
            this.Backgroundofgame.Image = ((System.Drawing.Image)(resources.GetObject("Backgroundofgame.Image")));
            this.Backgroundofgame.Location = new System.Drawing.Point(-1, -7);
            this.Backgroundofgame.Name = "Backgroundofgame";
            this.Backgroundofgame.Size = new System.Drawing.Size(706, 445);
            this.Backgroundofgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backgroundofgame.TabIndex = 0;
            this.Backgroundofgame.TabStop = false;
            // 
            // TryitagainButton
            // 
            this.TryitagainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TryitagainButton.Location = new System.Drawing.Point(12, 261);
            this.TryitagainButton.Name = "TryitagainButton";
            this.TryitagainButton.Size = new System.Drawing.Size(140, 46);
            this.TryitagainButton.TabIndex = 7;
            this.TryitagainButton.Text = "Try Again";
            this.TryitagainButton.UseVisualStyleBackColor = false;
            this.TryitagainButton.Click += new System.EventHandler(this.PlayAgainBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.TryitagainButton);
            this.Controls.Add(this.SwitchGunButton);
            this.Controls.Add(this.GunReloadButton);
            this.Controls.Add(this.ShootingButtornFaraway);
            this.Controls.Add(this.GunFiringButton);
            this.Controls.Add(this.Backgroundofgame);
            this.Name = "MainForm";
            this.Text = " MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Backgroundofgame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Backgroundofgame;
        private System.Windows.Forms.Button GunFiringButton;
        private System.Windows.Forms.Button ShootingButtornFaraway;
        private System.Windows.Forms.Button GunReloadButton;
        private System.Windows.Forms.Button SwitchGunButton;
        private System.Windows.Forms.Button TryitagainButton;
    }
}

