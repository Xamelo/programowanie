using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2ndMauiApp
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public bool IsUsed { get; set; }

        public Question(string text, List<string> answers, int correctAnswer, bool isUsed)
        {
            Text = text;
            Answers = answers;
            CorrectAnswer = correctAnswer;
            IsUsed = isUsed;
        }
    }
}
