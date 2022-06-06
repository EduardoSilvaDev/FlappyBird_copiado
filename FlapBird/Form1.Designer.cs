namespace FlapBird
{
    partial class flapbird
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebuttom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebuttom)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(6, 428);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(118, 25);
            this.lb_score.TabIndex = 4;
            this.lb_score.Text = "SCORE: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvents);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlapBird.Properties.Resources.stop;
            this.bird.Location = new System.Drawing.Point(10, 100);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.BackColor = System.Drawing.Color.Transparent;
            this.pipetop.Image = global::FlapBird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(311, 0);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(50, 250);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::FlapBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-1, 416);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(387, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipebuttom
            // 
            this.pipebuttom.BackColor = System.Drawing.Color.Transparent;
            this.pipebuttom.Image = global::FlapBird.Properties.Resources.pipe;
            this.pipebuttom.Location = new System.Drawing.Point(311, 350);
            this.pipebuttom.Name = "pipebuttom";
            this.pipebuttom.Size = new System.Drawing.Size(50, 250);
            this.pipebuttom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebuttom.TabIndex = 2;
            this.pipebuttom.TabStop = false;
            // 
            // flapbird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebuttom);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "flapbird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlapBird";
            this.Load += new System.EventHandler(this.flapbird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.previerKeyDown_func);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebuttom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebuttom;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipetop;
    }
}

