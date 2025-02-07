using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3rdMauiApp
{
    internal class Quiz3rdViewModel : BindableObject
    {
        private string questionText;

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; OnPropertyChanged(); }
        }

        private ObservableCollection<string> answers;

        public ObservableCollection<string> Answers
        {
            get { return answers; }
            set { answers = value; OnPropertyChanged(); }
        }


        private Command nextQuestionCommand;

        public Command NextQuestionCommand
        {
            get { return nextQuestionCommand; }
            set { nextQuestionCommand = value; }
        }

        private List<Question> allQuestions;

        private int gameScore = 0;
        private string gameScoreText;

        public string GameScoreText
        {
            get { return gameScoreText; }
            set { gameScoreText = value; OnPropertyChanged(); }
        }


        public Quiz3rdViewModel()
        {
            allQuestions = new List<Question>
            {
                new Question(
                    "Pytanie1",
                    new List<string> {"odp1.1", "odp1.2", "odp1.3", "odp1.4"},
                    1,
                    false),
                new Question(
                    "Pytanie2",
                    new List<string> {"odp2.1", "odp2.2", "odp2.3", "odp2.4"},
                    3,
                    false),
                new Question(
                    "Pytanie3",
                    new List<string> {"odp3.1", "odp3.2", "odp3.3", "odp3.4"},
                    0,
                    false),
                new Question(
                    "Pytanie4",
                    new List<string> {"odp4.1", "odp4.2", "odp4.3", "odp4.4"},
                    2,
                    false)
            };
            NextQuestionCommand = new Command(NextQuestion);
            QuestionText = "";
            GameScoreText = "";
            Random rand = new Random();
            allQuestions = allQuestions.OrderBy(q => rand.Next()).ToList();
        }

        private void NextQuestion()
        {
            Answers = new ObservableCollection<string>();
            Random rand = new Random();
            if (allQuestions.All(q => q.IsUsed))
            {
                QuestionText = "koniec";
                GameScoreText = gameScore.ToString();
                return;
            }

            int i;
            do
            {
                i = rand.Next(0, allQuestions.Count);
            } while (allQuestions[i].IsUsed);

            QuestionText = allQuestions[i].Text;
            allQuestions[i].IsUsed = true;

            for (int j = 0; j < 4; j++)
            {
                Answers.Add(allQuestions[i].Answers[j]);
            }
        }
    }
}
