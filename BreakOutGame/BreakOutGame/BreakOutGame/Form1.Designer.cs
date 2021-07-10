namespace BreakOutGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.plyer = new System.Windows.Forms.PictureBox();
            this.hammer = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(134, 32);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score : 0";
            // 
            // plyer
            // 
            this.plyer.BackColor = System.Drawing.Color.Gray;
            this.plyer.Location = new System.Drawing.Point(328, 600);
            this.plyer.Name = "plyer";
            this.plyer.Size = new System.Drawing.Size(115, 32);
            this.plyer.TabIndex = 1;
            this.plyer.TabStop = false;
            // 
            // hammer
            // 
            this.hammer.BackColor = System.Drawing.Color.Transparent;
            this.hammer.Image = ((System.Drawing.Image)(resources.GetObject("hammer.Image")));
            this.hammer.Location = new System.Drawing.Point(358, 362);
            this.hammer.Name = "hammer";
            this.hammer.Size = new System.Drawing.Size(59, 55);
            this.hammer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hammer.TabIndex = 2;
            this.hammer.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 644);
            this.Controls.Add(this.hammer);
            this.Controls.Add(this.plyer);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.plyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox plyer;
        private System.Windows.Forms.PictureBox hammer;
        private System.Windows.Forms.Timer gameTimer;
    }
}

