using System;
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
 * Version: 0.1 - Class created
 */
namespace COMP123_S2017_FinalExam_300932437
{
    class ScoreBoard
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
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }
        //methods
        public void UpdateTime()
        {
            int temp = Convert.ToInt32(TimeTextBox.Text);
            temp = temp - 1;
            this.Time = temp;
        }
    }
}
