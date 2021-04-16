namespace WindowsFormsApp1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.pbBlackHole = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackHole)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(105, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(154, 38);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbHeart3);
            this.panel1.Controls.Add(this.pbHeart2);
            this.panel1.Controls.Add(this.pbHeart1);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Location = new System.Drawing.Point(1, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 81);
            this.panel1.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(335, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 30);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inout:";
            // 
            // pbHeart3
            // 
            this.pbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart3.Image = global::WindowsFormsApp1.Properties.Resources.favpng_heart_clip_art1;
            this.pbHeart3.Location = new System.Drawing.Point(737, 17);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(50, 47);
            this.pbHeart3.TabIndex = 3;
            this.pbHeart3.TabStop = false;
            this.pbHeart3.Tag = "Heart";
            // 
            // pbHeart2
            // 
            this.pbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart2.Image = global::WindowsFormsApp1.Properties.Resources.favpng_heart_clip_art1;
            this.pbHeart2.Location = new System.Drawing.Point(653, 17);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(50, 47);
            this.pbHeart2.TabIndex = 2;
            this.pbHeart2.TabStop = false;
            this.pbHeart2.Tag = "Heart";
            // 
            // pbHeart1
            // 
            this.pbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart1.Image = global::WindowsFormsApp1.Properties.Resources.favpng_heart_clip_art1;
            this.pbHeart1.Location = new System.Drawing.Point(569, 17);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(50, 47);
            this.pbHeart1.TabIndex = 1;
            this.pbHeart1.TabStop = false;
            this.pbHeart1.Tag = "Heart";
            // 
            // pbBlackHole
            // 
            this.pbBlackHole.BackColor = System.Drawing.Color.Transparent;
            this.pbBlackHole.Image = global::WindowsFormsApp1.Properties.Resources.toppng_com_free_png_the_black_hole_in_space_png_images_transparent_transparent_black_hole_300x299;
            this.pbBlackHole.Location = new System.Drawing.Point(1, 64);
            this.pbBlackHole.Name = "pbBlackHole";
            this.pbBlackHole.Size = new System.Drawing.Size(293, 279);
            this.pbBlackHole.TabIndex = 4;
            this.pbBlackHole.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 65;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerRun);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.pbBlackHole);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rocket Typing Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlackHole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbHeart3;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBlackHole;
        private System.Windows.Forms.Timer gameTimer;
    }
}

