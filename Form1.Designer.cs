
namespace SnakeGame
{
    partial class FormSnakeGame
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreShow = new System.Windows.Forms.Label();
            this.panelGameArena = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(31, 15);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Xal :";
            // 
            // labelScoreShow
            // 
            this.labelScoreShow.AutoSize = true;
            this.labelScoreShow.Location = new System.Drawing.Point(72, 9);
            this.labelScoreShow.Name = "labelScoreShow";
            this.labelScoreShow.Size = new System.Drawing.Size(14, 15);
            this.labelScoreShow.TabIndex = 1;
            this.labelScoreShow.Text = "0";
            // 
            // panelGameArena
            // 
            this.panelGameArena.BackColor = System.Drawing.Color.Black;
            this.panelGameArena.Location = new System.Drawing.Point(10, 27);
            this.panelGameArena.Name = "panelGameArena";
            this.panelGameArena.Size = new System.Drawing.Size(570, 410);
            this.panelGameArena.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Controls.Add(this.labelScoreShow);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panelGameArena);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.FormSnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSnakeGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreShow;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panelGameArena;
    }
}

