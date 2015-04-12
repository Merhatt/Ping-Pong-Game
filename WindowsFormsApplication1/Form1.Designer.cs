namespace WindowsFormsApplication1
{
    partial class Game
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
            this.PlayGround = new System.Windows.Forms.Panel();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.NewGame = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Bot = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Bonus = new System.Windows.Forms.PictureBox();
            this.PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bonus)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayGround
            // 
            this.PlayGround.Controls.Add(this.Bonus);
            this.PlayGround.Controls.Add(this.Pause);
            this.PlayGround.Controls.Add(this.Continue);
            this.PlayGround.Controls.Add(this.Exit);
            this.PlayGround.Controls.Add(this.NewGame);
            this.PlayGround.Controls.Add(this.ball);
            this.PlayGround.Controls.Add(this.Bot);
            this.PlayGround.Controls.Add(this.Top);
            this.PlayGround.Controls.Add(this.Player2);
            this.PlayGround.Controls.Add(this.Player1);
            this.PlayGround.Location = new System.Drawing.Point(1, 12);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(801, 376);
            this.PlayGround.TabIndex = 0;
            this.PlayGround.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayGround_Paint);
            this.PlayGround.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayGround_MouseDown);
            // 
            // Pause
            // 
            this.Pause.Image = global::WindowsFormsApplication1.Properties.Resources.Pause;
            this.Pause.Location = new System.Drawing.Point(271, 11);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(256, 27);
            this.Pause.TabIndex = 7;
            this.Pause.TabStop = false;
            this.Pause.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Image = global::WindowsFormsApplication1.Properties.Resources.Countinue;
            this.Continue.Location = new System.Drawing.Point(271, 162);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(260, 27);
            this.Continue.TabIndex = 6;
            this.Continue.TabStop = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Continue_MouseDown);
            // 
            // Exit
            // 
            this.Exit.Image = global::WindowsFormsApplication1.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(271, 217);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(260, 28);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown_1);
            // 
            // NewGame
            // 
            this.NewGame.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.New_game;
            this.NewGame.Location = new System.Drawing.Point(271, 112);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(260, 26);
            this.NewGame.TabIndex = 5;
            this.NewGame.TabStop = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click_1);
            this.NewGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewGame_MouseDown);
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(379, 162);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(19, 20);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // Bot
            // 
            this.Bot.Location = new System.Drawing.Point(0, 370);
            this.Bot.Name = "Bot";
            this.Bot.Size = new System.Drawing.Size(798, 10);
            this.Bot.TabIndex = 3;
            this.Bot.TabStop = false;
            // 
            // Top
            // 
            this.Top.Location = new System.Drawing.Point(0, -20);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(798, 10);
            this.Top.TabIndex = 2;
            this.Top.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Player2.Location = new System.Drawing.Point(3, 135);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(14, 91);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Player1.Location = new System.Drawing.Point(784, 135);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(14, 91);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1: 0      Player 2: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            // 
            // Bonus
            // 
            this.Bonus.BackColor = System.Drawing.Color.Crimson;
            this.Bonus.Location = new System.Drawing.Point(365, -12);
            this.Bonus.Name = "Bonus";
            this.Bonus.Size = new System.Drawing.Size(18, 20);
            this.Bonus.TabIndex = 6;
            this.Bonus.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PlayGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bot;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox NewGame;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Continue;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Bonus;
    }
}

