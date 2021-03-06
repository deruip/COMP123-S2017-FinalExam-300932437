﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Aron Ly
 * Date: August 17, 2017
 * StudentID: 300932437
 * Description: ScoreBoard class for time/score fields and properties
 * Version: 0.2 - UpdateTime method created
 */
namespace COMP123_S2017_FinalExam_300932437
{
    public class ScoreBoard
    {
        // private instance variables
        TextBox _finalScoreTextBox;
        int _score;
        TextBox _scoreTextBox;
        int _time;
        TextBox _timeTextBox;

        // properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                this.ScoreTextBox.Text = Convert.ToString(_score);
                this.FinalScoreTextBox.Text = Convert.ToString(_score);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = Convert.ToString(_time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }
        // constructors
        /// <summary>
        /// Main constructor for ScoreBoard class
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }
        //methods
        /// <summary>
        /// Method that handles the time countdown
        /// </summary>
        public void UpdateTime()
        {
            int temp = Convert.ToInt32(TimeTextBox.Text);
            temp = temp - 1;
            this.Time = temp;
            this.TimeTextBox.Text = Convert.ToString(this.Time);
        }
    }
}
