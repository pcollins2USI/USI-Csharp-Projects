namespace A5_Bank
{
    partial class TrustBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrustBank));
            this.showBox = new System.Windows.Forms.TextBox();
            this.depositB = new System.Windows.Forms.Button();
            this.withdrawB = new System.Windows.Forms.Button();
            this.balanceB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showBox
            // 
            this.showBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.showBox.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.showBox.Location = new System.Drawing.Point(73, 12);
            this.showBox.Multiline = true;
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(161, 50);
            this.showBox.TabIndex = 0;
            this.showBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showBox.TextChanged += new System.EventHandler(this.showBox_TextChanged);
            // 
            // depositB
            // 
            this.depositB.BackColor = System.Drawing.Color.LemonChiffon;
            this.depositB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depositB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositB.Location = new System.Drawing.Point(12, 68);
            this.depositB.Name = "depositB";
            this.depositB.Size = new System.Drawing.Size(108, 54);
            this.depositB.TabIndex = 1;
            this.depositB.Text = "Deposit";
            this.depositB.UseVisualStyleBackColor = false;
            this.depositB.Click += new System.EventHandler(this.depositB_Click);
            // 
            // withdrawB
            // 
            this.withdrawB.BackColor = System.Drawing.Color.LemonChiffon;
            this.withdrawB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrawB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawB.Location = new System.Drawing.Point(126, 68);
            this.withdrawB.Name = "withdrawB";
            this.withdrawB.Size = new System.Drawing.Size(108, 54);
            this.withdrawB.TabIndex = 2;
            this.withdrawB.Text = "Withdraw";
            this.withdrawB.UseVisualStyleBackColor = false;
            this.withdrawB.Click += new System.EventHandler(this.withdrawB_Click);
            // 
            // balanceB
            // 
            this.balanceB.BackColor = System.Drawing.Color.LemonChiffon;
            this.balanceB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceB.Location = new System.Drawing.Point(12, 128);
            this.balanceB.Name = "balanceB";
            this.balanceB.Size = new System.Drawing.Size(222, 49);
            this.balanceB.TabIndex = 3;
            this.balanceB.Text = "Balance";
            this.balanceB.UseVisualStyleBackColor = false;
            this.balanceB.Click += new System.EventHandler(this.balanceB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TrustBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(248, 199);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balanceB);
            this.Controls.Add(this.withdrawB);
            this.Controls.Add(this.depositB);
            this.Controls.Add(this.showBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrustBank";
            this.Text = "Bank of Trust";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showBox;
        private System.Windows.Forms.Button depositB;
        private System.Windows.Forms.Button withdrawB;
        private System.Windows.Forms.Button balanceB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

