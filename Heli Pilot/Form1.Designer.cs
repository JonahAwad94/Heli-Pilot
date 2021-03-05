namespace Heli_Pilot
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
            this.Helicopter = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle1A = new System.Windows.Forms.PictureBox();
            this.obstacle1B = new System.Windows.Forms.PictureBox();
            this.obstacle2B = new System.Windows.Forms.PictureBox();
            this.obstacle2A = new System.Windows.Forms.PictureBox();
            this.obstacle3B = new System.Windows.Forms.PictureBox();
            this.obstacle3A = new System.Windows.Forms.PictureBox();
            this.obstacle4B = new System.Windows.Forms.PictureBox();
            this.obstacle4A = new System.Windows.Forms.PictureBox();
            this.obstacle5B = new System.Windows.Forms.PictureBox();
            this.obstacle5A = new System.Windows.Forms.PictureBox();
            this.obstacle6B = new System.Windows.Forms.PictureBox();
            this.obstacle6A = new System.Windows.Forms.PictureBox();
            this.obstacle7B = new System.Windows.Forms.PictureBox();
            this.obstacle7A = new System.Windows.Forms.PictureBox();
            this.obstacle8B = new System.Windows.Forms.PictureBox();
            this.obstacle8A = new System.Windows.Forms.PictureBox();
            this.obstacle9B = new System.Windows.Forms.PictureBox();
            this.obstacle9A = new System.Windows.Forms.PictureBox();
            this.obstacle13B = new System.Windows.Forms.PictureBox();
            this.obstacle13A = new System.Windows.Forms.PictureBox();
            this.obstacle12B = new System.Windows.Forms.PictureBox();
            this.obstacle12A = new System.Windows.Forms.PictureBox();
            this.obstacle11B = new System.Windows.Forms.PictureBox();
            this.obstacle11A = new System.Windows.Forms.PictureBox();
            this.obstacle10B = new System.Windows.Forms.PictureBox();
            this.obstacle10A = new System.Windows.Forms.PictureBox();
            this.obstacle14B = new System.Windows.Forms.PictureBox();
            this.obstacle14A = new System.Windows.Forms.PictureBox();
            this.gameScore = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.NewHighScoreLabel = new System.Windows.Forms.Label();
            this.endGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Helicopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle4B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle4A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle6B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle6A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle7B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle7A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle8B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle8A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle9B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle9A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle13B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle13A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle12B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle12A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle11B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle11A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle10B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle10A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle14B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle14A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Helicopter
            // 
            this.Helicopter.BackColor = System.Drawing.Color.Transparent;
            this.Helicopter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Helicopter.Image = global::Heli_Pilot.Properties.Resources.helicopter1;
            this.Helicopter.Location = new System.Drawing.Point(51, 260);
            this.Helicopter.Margin = new System.Windows.Forms.Padding(0);
            this.Helicopter.Name = "Helicopter";
            this.Helicopter.Size = new System.Drawing.Size(176, 60);
            this.Helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Helicopter.TabIndex = 0;
            this.Helicopter.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // obstacle1A
            // 
            this.obstacle1A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle1A.BackColor = System.Drawing.Color.Lime;
            this.obstacle1A.Location = new System.Drawing.Point(288, -380);
            this.obstacle1A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle1A.Name = "obstacle1A";
            this.obstacle1A.Size = new System.Drawing.Size(90, 600);
            this.obstacle1A.TabIndex = 1;
            this.obstacle1A.TabStop = false;
            // 
            // obstacle1B
            // 
            this.obstacle1B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle1B.BackColor = System.Drawing.Color.Lime;
            this.obstacle1B.Location = new System.Drawing.Point(288, 420);
            this.obstacle1B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle1B.Name = "obstacle1B";
            this.obstacle1B.Size = new System.Drawing.Size(90, 600);
            this.obstacle1B.TabIndex = 2;
            this.obstacle1B.TabStop = false;
            // 
            // obstacle2B
            // 
            this.obstacle2B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle2B.BackColor = System.Drawing.Color.Lime;
            this.obstacle2B.Location = new System.Drawing.Point(358, 420);
            this.obstacle2B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle2B.Name = "obstacle2B";
            this.obstacle2B.Size = new System.Drawing.Size(90, 600);
            this.obstacle2B.TabIndex = 4;
            this.obstacle2B.TabStop = false;
            // 
            // obstacle2A
            // 
            this.obstacle2A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle2A.BackColor = System.Drawing.Color.Lime;
            this.obstacle2A.Location = new System.Drawing.Point(358, -380);
            this.obstacle2A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle2A.Name = "obstacle2A";
            this.obstacle2A.Size = new System.Drawing.Size(90, 600);
            this.obstacle2A.TabIndex = 3;
            this.obstacle2A.TabStop = false;
            // 
            // obstacle3B
            // 
            this.obstacle3B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle3B.BackColor = System.Drawing.Color.Lime;
            this.obstacle3B.Location = new System.Drawing.Point(428, 420);
            this.obstacle3B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle3B.Name = "obstacle3B";
            this.obstacle3B.Size = new System.Drawing.Size(90, 600);
            this.obstacle3B.TabIndex = 6;
            this.obstacle3B.TabStop = false;
            // 
            // obstacle3A
            // 
            this.obstacle3A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle3A.BackColor = System.Drawing.Color.Lime;
            this.obstacle3A.Location = new System.Drawing.Point(428, -380);
            this.obstacle3A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle3A.Name = "obstacle3A";
            this.obstacle3A.Size = new System.Drawing.Size(90, 600);
            this.obstacle3A.TabIndex = 5;
            this.obstacle3A.TabStop = false;
            // 
            // obstacle4B
            // 
            this.obstacle4B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle4B.BackColor = System.Drawing.Color.Lime;
            this.obstacle4B.Location = new System.Drawing.Point(498, 420);
            this.obstacle4B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle4B.Name = "obstacle4B";
            this.obstacle4B.Size = new System.Drawing.Size(90, 600);
            this.obstacle4B.TabIndex = 8;
            this.obstacle4B.TabStop = false;
            // 
            // obstacle4A
            // 
            this.obstacle4A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle4A.BackColor = System.Drawing.Color.Lime;
            this.obstacle4A.Location = new System.Drawing.Point(498, -380);
            this.obstacle4A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle4A.Name = "obstacle4A";
            this.obstacle4A.Size = new System.Drawing.Size(90, 600);
            this.obstacle4A.TabIndex = 7;
            this.obstacle4A.TabStop = false;
            // 
            // obstacle5B
            // 
            this.obstacle5B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle5B.BackColor = System.Drawing.Color.Lime;
            this.obstacle5B.Location = new System.Drawing.Point(568, 420);
            this.obstacle5B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle5B.Name = "obstacle5B";
            this.obstacle5B.Size = new System.Drawing.Size(90, 600);
            this.obstacle5B.TabIndex = 10;
            this.obstacle5B.TabStop = false;
            // 
            // obstacle5A
            // 
            this.obstacle5A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle5A.BackColor = System.Drawing.Color.Lime;
            this.obstacle5A.Location = new System.Drawing.Point(568, -380);
            this.obstacle5A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle5A.Name = "obstacle5A";
            this.obstacle5A.Size = new System.Drawing.Size(90, 600);
            this.obstacle5A.TabIndex = 9;
            this.obstacle5A.TabStop = false;
            // 
            // obstacle6B
            // 
            this.obstacle6B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle6B.BackColor = System.Drawing.Color.Lime;
            this.obstacle6B.Location = new System.Drawing.Point(638, 420);
            this.obstacle6B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle6B.Name = "obstacle6B";
            this.obstacle6B.Size = new System.Drawing.Size(90, 600);
            this.obstacle6B.TabIndex = 12;
            this.obstacle6B.TabStop = false;
            // 
            // obstacle6A
            // 
            this.obstacle6A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle6A.BackColor = System.Drawing.Color.Lime;
            this.obstacle6A.Location = new System.Drawing.Point(638, -380);
            this.obstacle6A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle6A.Name = "obstacle6A";
            this.obstacle6A.Size = new System.Drawing.Size(90, 600);
            this.obstacle6A.TabIndex = 11;
            this.obstacle6A.TabStop = false;
            // 
            // obstacle7B
            // 
            this.obstacle7B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle7B.BackColor = System.Drawing.Color.Lime;
            this.obstacle7B.Location = new System.Drawing.Point(708, 420);
            this.obstacle7B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle7B.Name = "obstacle7B";
            this.obstacle7B.Size = new System.Drawing.Size(90, 600);
            this.obstacle7B.TabIndex = 14;
            this.obstacle7B.TabStop = false;
            // 
            // obstacle7A
            // 
            this.obstacle7A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle7A.BackColor = System.Drawing.Color.Lime;
            this.obstacle7A.Location = new System.Drawing.Point(708, -380);
            this.obstacle7A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle7A.Name = "obstacle7A";
            this.obstacle7A.Size = new System.Drawing.Size(90, 600);
            this.obstacle7A.TabIndex = 13;
            this.obstacle7A.TabStop = false;
            // 
            // obstacle8B
            // 
            this.obstacle8B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle8B.BackColor = System.Drawing.Color.Lime;
            this.obstacle8B.Location = new System.Drawing.Point(778, 420);
            this.obstacle8B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle8B.Name = "obstacle8B";
            this.obstacle8B.Size = new System.Drawing.Size(90, 600);
            this.obstacle8B.TabIndex = 16;
            this.obstacle8B.TabStop = false;
            // 
            // obstacle8A
            // 
            this.obstacle8A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle8A.BackColor = System.Drawing.Color.Lime;
            this.obstacle8A.Location = new System.Drawing.Point(778, -380);
            this.obstacle8A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle8A.Name = "obstacle8A";
            this.obstacle8A.Size = new System.Drawing.Size(90, 600);
            this.obstacle8A.TabIndex = 15;
            this.obstacle8A.TabStop = false;
            // 
            // obstacle9B
            // 
            this.obstacle9B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle9B.BackColor = System.Drawing.Color.Lime;
            this.obstacle9B.Location = new System.Drawing.Point(848, 420);
            this.obstacle9B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle9B.Name = "obstacle9B";
            this.obstacle9B.Size = new System.Drawing.Size(90, 600);
            this.obstacle9B.TabIndex = 18;
            this.obstacle9B.TabStop = false;
            // 
            // obstacle9A
            // 
            this.obstacle9A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle9A.BackColor = System.Drawing.Color.Lime;
            this.obstacle9A.Location = new System.Drawing.Point(848, -380);
            this.obstacle9A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle9A.Name = "obstacle9A";
            this.obstacle9A.Size = new System.Drawing.Size(90, 600);
            this.obstacle9A.TabIndex = 17;
            this.obstacle9A.TabStop = false;
            // 
            // obstacle13B
            // 
            this.obstacle13B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle13B.BackColor = System.Drawing.Color.Lime;
            this.obstacle13B.Location = new System.Drawing.Point(1128, 420);
            this.obstacle13B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle13B.Name = "obstacle13B";
            this.obstacle13B.Size = new System.Drawing.Size(90, 600);
            this.obstacle13B.TabIndex = 26;
            this.obstacle13B.TabStop = false;
            // 
            // obstacle13A
            // 
            this.obstacle13A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle13A.BackColor = System.Drawing.Color.Lime;
            this.obstacle13A.Location = new System.Drawing.Point(1128, -380);
            this.obstacle13A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle13A.Name = "obstacle13A";
            this.obstacle13A.Size = new System.Drawing.Size(90, 600);
            this.obstacle13A.TabIndex = 25;
            this.obstacle13A.TabStop = false;
            // 
            // obstacle12B
            // 
            this.obstacle12B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle12B.BackColor = System.Drawing.Color.Lime;
            this.obstacle12B.Location = new System.Drawing.Point(1058, 420);
            this.obstacle12B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle12B.Name = "obstacle12B";
            this.obstacle12B.Size = new System.Drawing.Size(90, 600);
            this.obstacle12B.TabIndex = 24;
            this.obstacle12B.TabStop = false;
            // 
            // obstacle12A
            // 
            this.obstacle12A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle12A.BackColor = System.Drawing.Color.Lime;
            this.obstacle12A.Location = new System.Drawing.Point(1058, -380);
            this.obstacle12A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle12A.Name = "obstacle12A";
            this.obstacle12A.Size = new System.Drawing.Size(90, 600);
            this.obstacle12A.TabIndex = 23;
            this.obstacle12A.TabStop = false;
            // 
            // obstacle11B
            // 
            this.obstacle11B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle11B.BackColor = System.Drawing.Color.Lime;
            this.obstacle11B.Location = new System.Drawing.Point(988, 420);
            this.obstacle11B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle11B.Name = "obstacle11B";
            this.obstacle11B.Size = new System.Drawing.Size(90, 600);
            this.obstacle11B.TabIndex = 22;
            this.obstacle11B.TabStop = false;
            // 
            // obstacle11A
            // 
            this.obstacle11A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle11A.BackColor = System.Drawing.Color.Lime;
            this.obstacle11A.Location = new System.Drawing.Point(988, -380);
            this.obstacle11A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle11A.Name = "obstacle11A";
            this.obstacle11A.Size = new System.Drawing.Size(90, 600);
            this.obstacle11A.TabIndex = 21;
            this.obstacle11A.TabStop = false;
            // 
            // obstacle10B
            // 
            this.obstacle10B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle10B.BackColor = System.Drawing.Color.Lime;
            this.obstacle10B.Location = new System.Drawing.Point(918, 420);
            this.obstacle10B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle10B.Name = "obstacle10B";
            this.obstacle10B.Size = new System.Drawing.Size(90, 600);
            this.obstacle10B.TabIndex = 20;
            this.obstacle10B.TabStop = false;
            // 
            // obstacle10A
            // 
            this.obstacle10A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle10A.BackColor = System.Drawing.Color.Lime;
            this.obstacle10A.Location = new System.Drawing.Point(918, -380);
            this.obstacle10A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle10A.Name = "obstacle10A";
            this.obstacle10A.Size = new System.Drawing.Size(90, 600);
            this.obstacle10A.TabIndex = 19;
            this.obstacle10A.TabStop = false;
            // 
            // obstacle14B
            // 
            this.obstacle14B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle14B.BackColor = System.Drawing.Color.Lime;
            this.obstacle14B.Location = new System.Drawing.Point(1198, 420);
            this.obstacle14B.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle14B.Name = "obstacle14B";
            this.obstacle14B.Size = new System.Drawing.Size(90, 600);
            this.obstacle14B.TabIndex = 28;
            this.obstacle14B.TabStop = false;
            // 
            // obstacle14A
            // 
            this.obstacle14A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacle14A.BackColor = System.Drawing.Color.Lime;
            this.obstacle14A.Location = new System.Drawing.Point(1198, -380);
            this.obstacle14A.Margin = new System.Windows.Forms.Padding(0);
            this.obstacle14A.Name = "obstacle14A";
            this.obstacle14A.Size = new System.Drawing.Size(90, 600);
            this.obstacle14A.TabIndex = 27;
            this.obstacle14A.TabStop = false;
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.BackColor = System.Drawing.Color.Transparent;
            this.gameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScore.Location = new System.Drawing.Point(76, 9);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(24, 25);
            this.gameScore.TabIndex = 29;
            this.gameScore.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(8, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(74, 25);
            this.scoreLabel.TabIndex = 30;
            this.scoreLabel.Text = "Score:";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.gameOverLabel.Location = new System.Drawing.Point(352, 193);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(207, 39);
            this.gameOverLabel.TabIndex = 31;
            this.gameOverLabel.Text = "Game Over!";
            this.gameOverLabel.Visible = false;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkGreen;
            this.playAgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playAgainButton.Enabled = false;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.White;
            this.playAgainButton.Location = new System.Drawing.Point(382, 235);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(136, 36);
            this.playAgainButton.TabIndex = 32;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.highScoreLabel.Location = new System.Drawing.Point(332, 274);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(207, 39);
            this.highScoreLabel.TabIndex = 33;
            this.highScoreLabel.Text = "High Score: ";
            this.highScoreLabel.Visible = false;
            // 
            // NewHighScoreLabel
            // 
            this.NewHighScoreLabel.AutoSize = true;
            this.NewHighScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewHighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScoreLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.NewHighScoreLabel.Location = new System.Drawing.Point(287, 313);
            this.NewHighScoreLabel.Name = "NewHighScoreLabel";
            this.NewHighScoreLabel.Size = new System.Drawing.Size(335, 39);
            this.NewHighScoreLabel.TabIndex = 34;
            this.NewHighScoreLabel.Text = "NEW HIGH SCORE!";
            this.NewHighScoreLabel.Visible = false;
            // 
            // endGameTimer
            // 
            this.endGameTimer.Tick += new System.EventHandler(this.endGameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.NewHighScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.obstacle14B);
            this.Controls.Add(this.obstacle14A);
            this.Controls.Add(this.obstacle13B);
            this.Controls.Add(this.obstacle13A);
            this.Controls.Add(this.obstacle12B);
            this.Controls.Add(this.obstacle12A);
            this.Controls.Add(this.obstacle11B);
            this.Controls.Add(this.obstacle11A);
            this.Controls.Add(this.obstacle10B);
            this.Controls.Add(this.obstacle10A);
            this.Controls.Add(this.obstacle9B);
            this.Controls.Add(this.obstacle9A);
            this.Controls.Add(this.obstacle8B);
            this.Controls.Add(this.obstacle8A);
            this.Controls.Add(this.obstacle7B);
            this.Controls.Add(this.obstacle7A);
            this.Controls.Add(this.obstacle6B);
            this.Controls.Add(this.obstacle6A);
            this.Controls.Add(this.obstacle5B);
            this.Controls.Add(this.obstacle5A);
            this.Controls.Add(this.obstacle4B);
            this.Controls.Add(this.obstacle4A);
            this.Controls.Add(this.obstacle3B);
            this.Controls.Add(this.obstacle3A);
            this.Controls.Add(this.obstacle2B);
            this.Controls.Add(this.obstacle2A);
            this.Controls.Add(this.obstacle1B);
            this.Controls.Add(this.obstacle1A);
            this.Controls.Add(this.Helicopter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Heli Pilot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPressed);
            ((System.ComponentModel.ISupportInitialize)(this.Helicopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle4B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle4A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle6B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle6A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle7B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle7A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle8B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle8A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle9B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle9A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle13B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle13A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle12B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle12A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle11B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle11A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle10B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle10A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle14B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle14A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Helicopter;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obstacle1A;
        private System.Windows.Forms.PictureBox obstacle1B;
        private System.Windows.Forms.PictureBox obstacle2B;
        private System.Windows.Forms.PictureBox obstacle2A;
        private System.Windows.Forms.PictureBox obstacle3B;
        private System.Windows.Forms.PictureBox obstacle3A;
        private System.Windows.Forms.PictureBox obstacle4B;
        private System.Windows.Forms.PictureBox obstacle4A;
        private System.Windows.Forms.PictureBox obstacle5B;
        private System.Windows.Forms.PictureBox obstacle5A;
        private System.Windows.Forms.PictureBox obstacle6B;
        private System.Windows.Forms.PictureBox obstacle6A;
        private System.Windows.Forms.PictureBox obstacle7B;
        private System.Windows.Forms.PictureBox obstacle7A;
        private System.Windows.Forms.PictureBox obstacle8B;
        private System.Windows.Forms.PictureBox obstacle8A;
        private System.Windows.Forms.PictureBox obstacle9B;
        private System.Windows.Forms.PictureBox obstacle9A;
        private System.Windows.Forms.PictureBox obstacle13B;
        private System.Windows.Forms.PictureBox obstacle13A;
        private System.Windows.Forms.PictureBox obstacle12B;
        private System.Windows.Forms.PictureBox obstacle12A;
        private System.Windows.Forms.PictureBox obstacle11B;
        private System.Windows.Forms.PictureBox obstacle11A;
        private System.Windows.Forms.PictureBox obstacle10B;
        private System.Windows.Forms.PictureBox obstacle10A;
        private System.Windows.Forms.PictureBox obstacle14B;
        private System.Windows.Forms.PictureBox obstacle14A;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label NewHighScoreLabel;
        private System.Windows.Forms.Timer endGameTimer;
    }
}

