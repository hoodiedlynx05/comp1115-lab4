namespace WinFormsQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnRestart;
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnToggleTheme = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(661, 338);
            btnRestart.Margin = new Padding(4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(118, 36);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(516, 338);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 16F);
            lblMessage.Location = new Point(375, 76);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(368, 45);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(99, 190);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(232, 25);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan?";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(659, 190);
            txtAnswer.Margin = new Padding(4);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(552, 31);
            txtAnswer.TabIndex = 3;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(808, 338);
            btnToggleTheme.Margin = new Padding(4);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(145, 36);
            btnToggleTheme.TabIndex = 5;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 774);
            Controls.Add(btnToggleTheme);
            Controls.Add(btnRestart);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnToggleTheme;
        private Button btnRestart;
    }
}
