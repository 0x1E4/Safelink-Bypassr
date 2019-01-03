namespace Bypasser
{
    partial class Bypasser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bypasser));
            this.SmashBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.Penjelasan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SmashBtn
            // 
            this.SmashBtn.Location = new System.Drawing.Point(86, 107);
            this.SmashBtn.Name = "SmashBtn";
            this.SmashBtn.Size = new System.Drawing.Size(85, 33);
            this.SmashBtn.TabIndex = 0;
            this.SmashBtn.Text = "SMASH IT!";
            this.SmashBtn.UseVisualStyleBackColor = true;
            this.SmashBtn.Click += new System.EventHandler(this.SmashBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Location = new System.Drawing.Point(9, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(255, 25);
            this.Title.TabIndex = 3;
            this.Title.Text = "Safelink Bypasser v0.1a";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(237, 139);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(37, 13);
            this.Credits.TabIndex = 4;
            this.Credits.Text = "0x1E4";
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // Penjelasan
            // 
            this.Penjelasan.Location = new System.Drawing.Point(17, 38);
            this.Penjelasan.Name = "Penjelasan";
            this.Penjelasan.Size = new System.Drawing.Size(236, 17);
            this.Penjelasan.TabIndex = 5;
            this.Penjelasan.Text = "Bypass link code gapake pusing cuma 1x klik";
            this.Penjelasan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Penjelasan.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pertama, copy safelinknya dulu\r\n lalu tinggal pencet SMASH IT!. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Bypasser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(272, 152);
            this.Controls.Add(this.Penjelasan);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SmashBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bypasser";
            this.Opacity = 0.9D;
            this.Text = "Safelink Bypasser";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Link_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button SmashBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Label Penjelasan;
        private System.Windows.Forms.Label label1;
    }
}

