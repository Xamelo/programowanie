using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4thMauiApp
{
    internal class Quiz4thViewModel : BindableObject
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        private int currentQuestionIndex = 0;
        public int CurrentQuestionIndex
        {
            get { return currentQuestionIndex; }
            set { currentQuestionIndex = value; OnPropertyChanged(); OnPropertyChanged(nameof(CurrentQuestion)); }
        }
        private string resultLabelText;
        public string ResultLabelText
        {
            get { return resultLabelText; }
            set { resultLabelText = value; OnPropertyChanged(); }
        }
        public Question CurrentQuestion => Questions[CurrentQuestionIndex];
        public Command PreviousQuestionCommand { get; set; }
        public Command NextQuestionCommand { get; set; }
        public Command ResetCommand { get; set; }
        public Command CheckAnswersCommand { get; set; }
        public Quiz4thViewModel()
        {
            PreviousQuestionCommand = new Command(PreviousQuestion);
            NextQuestionCommand = new Command(NextQuestion);
            CheckAnswersCommand = new Command(CheckAnswers);
            ResetCommand = new Command(Reset);
            Questions = new List<Question>
            {
                new Question { QuestionText = "czy big c zdal prawo jazdy", Answers=["nie", "nie", "nie", "nie xd"],CorrectAnswer = 3 },
                new Question { QuestionText = "co robi kacu na programowaniu",Answers=["nic","spi","oglada tiktoka","udaje ze cos umie"], CorrectAnswer = 2 },
                new Question { QuestionText = "ile skuty ma majatku",Answers=["malo","za duzo","tfu tfu tfu","5 zl"], CorrectAnswer = 1 },
                new Question { QuestionText = "ile lat ma pani ewa k",Answers=["18","69","w sam raz","wiecej niz 10000 ale mniej niz 10000000000"], CorrectAnswer = 0 },
                new Question { QuestionText = "co lubi kuba",Answers=["nic","nic","nic","tik toka"], CorrectAnswer = 3 },
            };
        }
        public void PreviousQuestion()
        {
            if (CurrentQuestionIndex > 0)
            {
                InsertAnswers();
                CurrentQuestionIndex--;
                RestoreRadioButtons();
            }

        }
        public void NextQuestion()
        {
            if (CurrentQuestionIndex < Questions.Count - 1)
            {
                InsertAnswers();
                CurrentQuestionIndex++;
                RestoreRadioButtons();
            }

        }
        public void Reset()
        {
            foreach (Question question in Questions)
            {
                question.CurrentAnswer = -1;
                Checked0 = false;
                Checked1 = false;
                Checked2 = false;
                Checked3 = false;
                ResultLabelText = "";
                InsertAnswers();
                RestoreRadioButtons();
            }
        }
        public void CheckAnswers()
        {
            InsertAnswers();
            RestoreRadioButtons();
            int score = 0;

            for (int i = 0; i < Questions.Count; i++)
            {
                if (Questions[i].CurrentAnswer == Questions[i].CorrectAnswer)
                {
                    score++;
                }
            }
            ResultLabelText = $"Wynik: {score}/{Questions.Count()}";

        }
        #region radio buttons
        private bool checked0;
        private bool checked1;
        private bool checked2;
        private bool checked3;
        public bool Checked0 { get { return checked0; } set { checked0 = value; OnPropertyChanged(); } }
        public bool Checked1 { get { return checked1; } set { checked1 = value; OnPropertyChanged(); } }
        public bool Checked2 { get { return checked2; } set { checked2 = value; OnPropertyChanged(); } }
        public bool Checked3 { get { return checked3; } set { checked3 = value; OnPropertyChanged(); } }
        private void InsertAnswers()
        {
            if (checked0) { CurrentQuestion.CurrentAnswer = 0; }
            if (checked1) { CurrentQuestion.CurrentAnswer = 1; }
            if (checked2) { CurrentQuestion.CurrentAnswer = 2; }
            if (checked3) { CurrentQuestion.CurrentAnswer = 3; }
        }
        private void RestoreRadioButtons()
        {


            switch (CurrentQuestion.CurrentAnswer)
            {
                case 0:
                    Checked0 = true;
                    Checked1 = false;
                    Checked2 = false;
                    Checked3 = false;
                    break;

                case 1:
                    Checked1 = true;
                    Checked2 = false;
                    Checked3 = false;
                    Checked0 = false;
                    break;

                case 2:
                    Checked2 = true;
                    Checked3 = false;
                    Checked1 = false;
                    Checked0 = false;
                    break;

                case 3:
                    Checked3 = true;
                    Checked1 = false;
                    Checked2 = false;
                    Checked0 = false;
                    break;

                default:
                    Checked0 = false;
                    Checked1 = false;
                    Checked2 = false;
                    Checked3 = false;
                    break;
            }

        }
        #endregion
    }
}
