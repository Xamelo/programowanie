using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMauiApp
{
    internal class QuizViewModel : BindableObject
    {
        private string resultOfTheGame;

        public string ResultOfTheGame
        {
            get { return resultOfTheGame; }
            set { resultOfTheGame = value; OnPropertyChanged(); }
        }


        private string question;

        public string Question
        {
            get { return question; }
            set { question = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> Questions { get; set; }

        #region commands
        private Command nextQuestionCommand;

        public Command NextQuestionCommand
        {
            get { return nextQuestionCommand; }
            set { nextQuestionCommand = value; }
        }

        private Command previousQuestionCommand;

        public Command PreviousQuestionCommand
        {
            get { return previousQuestionCommand; }
            set { previousQuestionCommand = value; }
        }

        private Command resetGameCommand;

        public Command ResetGameCommand
        {
            get { return resetGameCommand; }
            set { resetGameCommand = value; }
        }

        private Command checkResultCommand;

        public Command CheckResultCommand
        {
            get { return checkResultCommand; }
            set { checkResultCommand = value; }
        }
        #endregion

        const int AMOUNTofAnswers = 4;
        const int AMOUNTofQuestions = 4;
        int currentQuestion = 0;
        int score = 0;
        string[,] answers = new string[AMOUNTofAnswers, AMOUNTofQuestions] {
            {"a", "b", "poprawna", "d" },
            {"a", "poprawna", "c", "d" },
            {"poprawna", "b", "c", "d" },
            {"a", "b", "poprawna", "d" }
        };

        public QuizViewModel()
        {
            Questions = new ObservableCollection<string>();
            Questions.Add("pytanie1");
            Questions.Add("pytanie2");
            Questions.Add("pytanie3");
            Questions.Add("pytanie4");

            NextQuestionCommand = new Command(NextQuestion);
            PreviousQuestionCommand = new Command(PreviousQuestion);
            ResetGameCommand = new Command(ResetGame);
            checkResultCommand = new Command(CheckResult);

            Question = Questions.First();
            ResultOfTheGame = "Wynik: ";
        }

        private void NextQuestion()
        {
            if (currentQuestion < Questions.Count() - 1)
            {
                Question = Questions[currentQuestion + 1];
                currentQuestion++;
            }
            else
                return;
        }

        private void PreviousQuestion()
        {
            if (currentQuestion > 0)
            {
                Question = Questions[currentQuestion - 1];
                currentQuestion--;
            }
            else
                return;
        }

        private void CheckResult()
        {
            if (!ResultOfTheGame.Contains(score.ToString()))
                ResultOfTheGame += score.ToString();
        }

        private void ResetGame()
        {
            currentQuestion = 0;
            score = 0;
            ResultOfTheGame = "Wynik: ";
        }
    }
}
