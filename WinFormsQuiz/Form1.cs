using System.Windows.Forms.VisualStyles;

namespace WinFormsQuiz
{
    public struct Questions(string question, string answer)
    {
        public string question = question;
        public string answer = answer;
    }
    public partial class Form1 : Form
    {
        // array of questions and answers

        Questions[] questions = new Questions[6];

        // track current question
        int currentQuestion = 0;

        // track correct answers
        int correct = 0;

        bool isDark = false;

        // startup method that runs automatically when this form loads
        public Form1()
        {
            InitializeComponent();

            SetTheme();

            // call new LoadQuestions() method to populate quiz data
            LoadQuestions();
        }

        /// <summary>
        /// populate question / answer array
        /// </summary>
        /// <author>Rich</author>
        private void LoadQuestions()
        {
            // populate array
            questions[0] = new Questions("What's the capital of Japan?", "Tokyo");
            questions[1] = new Questions("What colour is the sky?", "Blue");
            questions[2] = new Questions("Which came first, the chicken or the egg?", "Egg");
            questions[3] = new Questions("What day is our class?", "Monday");
            questions[4] = new Questions("What is the longest day of the year?", "Summer Solstice");
            questions[5] = new Questions("Which month has the least number of days?", "February");

            // show 1st question on question label
            lblQuestion.Text = questions[0].question;
        }

        /// <summary>
        /// give feedback on answer
        /// </summary>
        /// <param name="text">feedback to show on label</param>
        /// <param name="colour">text color for feedback label</param>
        private void ShowFeedback(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;
        }

        /// <summary>
        /// user has finished
        /// </summary>
        private void FinishQuiz()
        {
            btnSubmit.Enabled = false;
            lblQuestion.Text = $"You got {correct} correct answers out of {questions.Length} questions.\nYour percentage is {GetPercentScore(correct, questions.Length)}%";
        }

        private static int GetPercentScore(int correct, int total)
        {
            return (correct * 100) / total;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text.ToLower() == questions[currentQuestion].answer.ToLower())
            {
                ShowFeedback("Correct", Color.Green);

                // add 1 to correct answer count
                correct++;
            }
            else
            {
                if (txtAnswer.Text.Split(" ")[0].ToLower() == "the")
                {
                    Console.WriteLine("contains a \"the\"");
                    string currentAnswer = string.Concat(txtAnswer.Text.Split(" ")[1..^0]);
                    if (currentAnswer.ToLower() == questions[currentQuestion].answer.ToLower())
                    {
                        ShowFeedback("Correct", Color.Green);
                        correct++;
                    }
                }
                else
                {
                    // wrong answer
                    ShowFeedback("Incorrect", Color.Red);
                }
            }

            // increment current question 
            currentQuestion++;

            // are there more questions?
            if (currentQuestion < questions.Length)
            {
                //  move to next question                
                lblQuestion.Text = questions[currentQuestion].question;
            }
            else
            {
                // user is done - no more questions
                FinishQuiz();
            }

            // clear last answer
            txtAnswer.Text = "";
        }
        private void Restart()
        {
            currentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the Quiz";
            if (isDark)
            {
                lblMessage.ForeColor = Color.Black;
            }
            else
            {
                lblMessage.ForeColor = Color.White;
            }
            lblQuestion.Text = questions[0].question;
            btnSubmit.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void SetTheme()
        {
            if (isDark)
            {
                this.BackColor = Color.Black;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                txtAnswer.ForeColor = Color.White;
                //btnSubmit.ForeColor = Color.Black;
                //btnRestart.ForeColor = Color.Black;
                //btnToggleTheme.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.Gray;
                isDark = false;
            }
            else
            {
                this.BackColor = Color.White;
                lblMessage.ForeColor = Color.Black;
                lblQuestion.ForeColor = Color.Black;
                txtAnswer.ForeColor = Color.Black;
                //btnSubmit.ForeColor = Color.White;
                //btnRestart.ForeColor = Color.White;
                //btnToggleTheme.ForeColor = Color.White;
                txtAnswer.BackColor = Color.DimGray;
                isDark = true;
            }
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            SetTheme();
        }
    }
}
