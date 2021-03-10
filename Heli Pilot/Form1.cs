﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heli_Pilot
{
    public partial class Form1 : Form
    {

        // Obstacle speed is currently unchanged throughout gameplay,
        // can be raised later to increase difficulty.
        int obstacleSpeed = 15;

        int explosionSprite = 0;
        int verticleDirection = 0;
        int horizontalDirection = 0;
        int score = 0;
        int highscore = 0;
        int HeliSprite = 0;
        bool gamePaused = false;
        bool musicMuted = false;
        readonly Random rand = new Random();
        readonly System.Media.SoundPlayer musicPlayer = new System.Media.SoundPlayer(Properties.Resources.music);
        readonly System.Media.SoundPlayer explosionPlayer = new System.Media.SoundPlayer(Properties.Resources.ExplosionSound);


        public Form1()
        {
            InitializeComponent();
            this.highscore = LoadHighScore();
            musicPlayer.PlayLooping();
        }

        private int LoadHighScore()
        {
            if(File.Exists("HighScore.txt"))
            {
                try
                {
                    int _highscore = Convert.ToInt32(File.ReadAllText("HighScore.txt"));
                    return _highscore;
                }
                catch(Exception) // error in reading highScore.txt, reset high score
                {
                    return 0;
                }
            }
            return 0;
        }

        private void SaveHighScore(int newScore)
        {
            File.WriteAllText("HighScore.txt", newScore.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyDownPressed(object sender, KeyEventArgs e)
        {
            // Move Down
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                verticleDirection = 12;
            }

            // Move Up
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                verticleDirection = -12;
            }

            // Move Left
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                horizontalDirection = -12;
            }

            // Move Right
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                horizontalDirection = 12;
            }

            // Mute/unmute music
            if (e.KeyCode == Keys.M)
            {
                if (musicMuted)
                {
                    musicPlayer.PlayLooping();
                    muteLabel.Visible = false;
                    musicMuted = false;
                }
                else
                {
                    musicPlayer.Stop();
                    muteLabel.Visible = true;
                    musicMuted = true;
                }
            }

            // Pause/resume game
            if (e.KeyCode == Keys.P)
            {
                if (gamePaused)
                {
                    gameTimer.Start();
                    pauseLabel.Visible = false;
                    gamePaused = false;
                }
                else
                {
                    gameTimer.Stop();
                    pauseLabel.Visible = true;
                    gamePaused = true;
                }
            }
        }

        private void KeyUpPressed(object sender, KeyEventArgs e)
        {
            verticleDirection = 0;
            horizontalDirection = 0;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Helicopter.Top += verticleDirection;
            Helicopter.Left += horizontalDirection;
            score++;
            gameScore.Text = score.ToString();

            // IDEA FOR LATER
            // Can be used with increased obstacle speed
            // Change background game progress
            //if (score == 500)
            //{
            //    this.BackColor = Color.FromArgb(90, 180, 180);
            //}
            //else if (score == 1000)
            //{
            //    this.BackColor = Color.FromArgb(60, 120, 120);
            //}
            //else if (score == 1500)
            //{
            //    this.BackColor = Color.FromArgb(30, 60, 60);
            //}
            //else if (score == 2000)
            //{
            //    this.BackColor = Color.FromArgb(15, 30, 30);
            //}

            // Iterate through all Helicopter sprites to give the
            // illusion of the Helicopter's rotors spinning
            if (HeliSprite == 0)
            {
                Helicopter.Image = Properties.Resources.helicopter1;
                HeliSprite++;
            }
            else if (HeliSprite == 1)
            {
                Helicopter.Image = Properties.Resources.helicopter2;
                HeliSprite++;
            }
            else if (HeliSprite == 2)
            {
                Helicopter.Image = Properties.Resources.helicopter3;
                HeliSprite++;
            }
            else
            {
                Helicopter.Image = Properties.Resources.helicopter4;
                HeliSprite = 0;
            }

            // Detect Collision
            if (
                Helicopter.Bounds.IntersectsWith(obstacle1A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle1B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle2A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle2B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle3A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle3B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle4A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle4B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle5A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle5B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle6A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle6B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle7A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle7B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle8A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle8B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle9A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle9B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle10A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle10B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle11A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle11B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle12A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle12B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle13A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle13B.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle14A.Bounds) ||
                Helicopter.Bounds.IntersectsWith(obstacle14B.Bounds)
              )
            {
                EndGame();
            }

                //Move all obstacles
                obstacle1A.Left -= obstacleSpeed;
            if (obstacle1A.Left < -100)
            {
                obstacle1A.Left = 870;
                obstacle1A.Top = obstacle14A.Top + rand.Next(-50, 51);
                if (obstacle1A.Top < -600)
                    obstacle1A.Top = -600;
                if (obstacle1A.Top > -200)
                    obstacle1A.Top = -200;
            }
            obstacle1B.Left = obstacle1A.Left;
            obstacle1B.Top = obstacle1A.Top + 850;

            obstacle2A.Left -= obstacleSpeed;
            if (obstacle2A.Left < -100)
            {
                obstacle2A.Left = 870;
                obstacle2A.Top = obstacle1A.Top + rand.Next(-50, 51);
                if (obstacle2A.Top < -600)
                    obstacle2A.Top = -600;
                if (obstacle2A.Top > -200)
                    obstacle2A.Top = -200;
            }
            obstacle2B.Left = obstacle2A.Left;
            obstacle2B.Top = obstacle2A.Top + 850;

            obstacle3A.Left -= obstacleSpeed;
            if (obstacle3A.Left < -100)
            {
                obstacle3A.Left = 870;
                obstacle3A.Top = obstacle2A.Top + rand.Next(-50, 51);
                if (obstacle3A.Top < -600)
                    obstacle3A.Top = -600;
                if (obstacle3A.Top > -200)
                    obstacle3A.Top = -200;
            }
            obstacle3B.Left = obstacle3A.Left;
            obstacle3B.Top = obstacle3A.Top + 850;

            obstacle4A.Left -= obstacleSpeed;
            if (obstacle4A.Left < -100)
            {
                obstacle4A.Left = 870;
                obstacle4A.Top = obstacle3A.Top + rand.Next(-50, 51);
                if (obstacle4A.Top < -600)
                    obstacle4A.Top = -600;
                if (obstacle4A.Top > -200)
                    obstacle4A.Top = -200;
            }
            obstacle4B.Left = obstacle4A.Left;
            obstacle4B.Top = obstacle4A.Top + 850;

            obstacle5A.Left -= obstacleSpeed;
            if (obstacle5A.Left < -100)
            {
                obstacle5A.Left = 870;
                obstacle5A.Top = obstacle4A.Top + rand.Next(-50, 51);
                if (obstacle5A.Top < -600)
                    obstacle5A.Top = -600;
                if (obstacle5A.Top > -200)
                    obstacle5A.Top = -200;
            }
            obstacle5B.Left = obstacle5A.Left;
            obstacle5B.Top = obstacle5A.Top + 850;

            obstacle6A.Left -= obstacleSpeed;
            if (obstacle6A.Left < -100)
            {
                obstacle6A.Left = 870;
                obstacle6A.Top = obstacle5A.Top + rand.Next(-50, 51);
                if (obstacle6A.Top < -600)
                    obstacle6A.Top = -600;
                if (obstacle6A.Top > -200)
                    obstacle6A.Top = -200;
            }
            obstacle6B.Left = obstacle6A.Left;
            obstacle6B.Top = obstacle6A.Top + 850;

            obstacle7A.Left -= obstacleSpeed;
            if (obstacle7A.Left < -100)
            {
                obstacle7A.Left = 870;
                obstacle7A.Top = obstacle6A.Top + rand.Next(-50, 51);
                if (obstacle7A.Top < -600)
                    obstacle7A.Top = -600;
                if (obstacle7A.Top > -200)
                    obstacle7A.Top = -200;
            }
            obstacle7B.Left = obstacle7A.Left;
            obstacle7B.Top = obstacle7A.Top + 850;

            obstacle8A.Left -= obstacleSpeed;
            if (obstacle8A.Left < -100)
            {
                obstacle8A.Left = 870;
                obstacle8A.Top = obstacle7A.Top + rand.Next(-50, 51);
                if (obstacle8A.Top < -600)
                    obstacle8A.Top = -600;
                if (obstacle8A.Top > -200)
                    obstacle8A.Top = -200;
            }
            obstacle8B.Left = obstacle8A.Left;
            obstacle8B.Top = obstacle8A.Top + 850;

            obstacle9A.Left -= obstacleSpeed;
            if (obstacle9A.Left < -100)
            {
                obstacle9A.Left = 870;
                obstacle9A.Top = obstacle8A.Top + rand.Next(-50, 51);
                if (obstacle9A.Top < -600)
                    obstacle9A.Top = -600;
                if (obstacle9A.Top > -200)
                    obstacle9A.Top = -200;
            }
            obstacle9B.Left = obstacle9A.Left;
            obstacle9B.Top = obstacle9A.Top + 850;

            obstacle10A.Left -= obstacleSpeed;
            if (obstacle10A.Left < -100)
            {
                obstacle10A.Left = 870;
                obstacle10A.Top = obstacle9A.Top + rand.Next(-50, 51);
                if (obstacle10A.Top < -600)
                    obstacle10A.Top = -600;
                if (obstacle10A.Top > -200)
                    obstacle10A.Top = -200;
            }
            obstacle10B.Left = obstacle10A.Left;
            obstacle10B.Top = obstacle10A.Top + 850;

            obstacle11A.Left -= obstacleSpeed;
            if (obstacle11A.Left < -100)
            {
                obstacle11A.Left = 870;
                obstacle11A.Top = obstacle10A.Top + rand.Next(-50, 51);
                if (obstacle11A.Top < -600)
                    obstacle11A.Top = -600;
                if (obstacle11A.Top > -200)
                    obstacle11A.Top = -200;
            }
            obstacle11B.Left = obstacle11A.Left;
            obstacle11B.Top = obstacle11A.Top + 850;

            obstacle12A.Left -= obstacleSpeed;
            if (obstacle12A.Left < -100)
            {
                obstacle12A.Left = 870;
                obstacle12A.Top = obstacle11A.Top + rand.Next(-50, 51);
                if (obstacle12A.Top < -600)
                    obstacle12A.Top = -600;
                if (obstacle12A.Top > -200)
                    obstacle12A.Top = -200;
            }
            obstacle12B.Left = obstacle12A.Left;
            obstacle12B.Top = obstacle12A.Top + 850;

            obstacle13A.Left -= obstacleSpeed;
            if (obstacle13A.Left < -100)
            {
                obstacle13A.Left = 870;
                obstacle13A.Top = obstacle12A.Top + rand.Next(-50, 51);
                if (obstacle13A.Top < -600)
                    obstacle13A.Top = -600;
                if (obstacle13A.Top > -200)
                    obstacle13A.Top = -200;
            }
            obstacle13B.Left = obstacle13A.Left;
            obstacle13B.Top = obstacle13A.Top + 850;

            obstacle14A.Left -= obstacleSpeed;
            if (obstacle14A.Left < -100)
            {
                obstacle14A.Left = 870;
                obstacle14A.Top = obstacle13A.Top + rand.Next(-50, 51);
                if (obstacle14A.Top < -600)
                    obstacle14A.Top = -600;
                if (obstacle14A.Top > -200)
                    obstacle14A.Top = -200;
            }
            obstacle14B.Left = obstacle14A.Left;
            obstacle14B.Top = obstacle14A.Top + 850;
        }

        private void EndGame()
        {
            // End game timer, start end game timer
            gameTimer.Stop();
            endGameTimer.Start();

            musicPlayer.Stop();
            explosionPlayer.Play();

            // Display Game Over and play again button 
            gameOverLabel.Visible = true;
            playAgainButton.Enabled = true;
            playAgainButton.Visible = true;

            // update and save high score
            if (score > highscore)
            {
                highscore = score;
                SaveHighScore(highscore);
                NewHighScoreLabel.Visible = true;
            }

            // display high score
            highScoreLabel.Text = "High Score: " + highscore.ToString();
            highScoreLabel.Visible = true;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // End game timer used for explosion animation
        private void endGameTimer_Tick(object sender, EventArgs e)
        {
            if (explosionSprite == 0)
            {
                Helicopter.Image = Properties.Resources.explosion1;
                explosionSprite++;
            }
            else if (explosionSprite == 1)
            {
                Helicopter.Image = Properties.Resources.explosion2;
                explosionSprite++;
            }
            else if (explosionSprite == 2)
            {
                Helicopter.Image = Properties.Resources.explosion3;
                explosionSprite++;
            }
            else if (explosionSprite == 3)
            {
                Helicopter.Image = Properties.Resources.explosion4;
                explosionSprite++;
            }
            else if (explosionSprite == 4)
            {
                endGameTimer.Stop();
                Helicopter.Visible = false;
            }
        }
    }
}