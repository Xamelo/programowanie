using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2ndMauiApp
{
    internal class Quiz2ndViewModel : BindableObject
    {
        #region collections
        private ObservableCollection<string> questions;

		public ObservableCollection<string> Questions
		{
			get { return questions; }
			set { questions = value; OnPropertyChanged(); }
		}

		private ObservableCollection<string> answers;

		public ObservableCollection<string> Answers
		{
			get { return answers; }
			set { answers = value; OnPropertyChanged(); }
		}
		#endregion

		private Command nextQuestionCommand;

		public Command NextQuestionCommand
		{
			get 
			{
				if (nextQuestionCommand == null)
					nextQuestionCommand = new Command(
						() =>
						{
							if (remainingQuestions.Count > 0)
							{
								Questions = new ObservableCollection<string>();
								Answers = new ObservableCollection<string>();
								Random rand = new Random();

								int i = rand.Next(0, remainingQuestions.Count);
								if (!remainingQuestions[i].IsUsed)
								{
									Questions.Add(remainingQuestions[i].Text);
									for (int j = 0; j < 4; j++)
									{
										Answers.Add(remainingQuestions[i].Answers[j]);
									}
									currentQuestionIndex++;
									remainingQuestions[i].IsUsed = true;
								}
								else
								{
									
								}
							}
						}
					);

				return nextQuestionCommand;
			}
			set { nextQuestionCommand = value; }	
		}

		private Command previousQuestionCommand;

		public Command PreviousQuestionCommand
		{
			get 
			{
				if (currentQuestionIndex > 1)
				{
					
				}
				return previousQuestionCommand;
			}
			set { previousQuestionCommand = value; }
		}

		int currentQuestionIndex = 0;


		private List<Question> remainingQuestions;

        public Quiz2ndViewModel()
        {
			remainingQuestions = new List<Question>
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
					false)
			};
        }
    }
}
