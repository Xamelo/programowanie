using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4thMauiApp
{
    internal class Question : BindableObject
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
        private int currentAnswer = -1;
        public int CurrentAnswer
        {
            get { return currentAnswer; }
            set { currentAnswer = value; OnPropertyChanged(); }
        }
    }
}
