using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMauiApp
{
    public class DiceViewModel : BindableObject
    {
        #region props
        private string dice1;
		public string Dice1
		{
			get { return dice1; }
			set { dice1 = value; OnPropertyChanged(); }
		}

        private string dice2;
        public string Dice2
        {
            get { return dice2; }
            set { dice2 = value; OnPropertyChanged(); }
        }

        private string dice3;
        public string Dice3
        {
            get { return dice3; }
            set { dice3 = value; OnPropertyChanged(); }
        }

        private string dice4;
        public string Dice4
        {
            get { return dice4; }
            set { dice4 = value; OnPropertyChanged(); }
        }

        private string dice5;
        public string Dice5
        {
            get { return dice5; }
            set { dice5 = value; OnPropertyChanged(); }
        }

        private string resultOfTheGame;
		public string ResultOfTheGame
		{
			get { return resultOfTheGame; }
			set { resultOfTheGame = value; OnPropertyChanged(); }
		}

		private string rollResult;
		public string RollResult
		{
			get { return rollResult; }
			set { rollResult = value; OnPropertyChanged(); }
		}

		private Command rollDiceCommand;
		public Command RollDiceCommand
        {
			get { return rollDiceCommand; }
			set { rollDiceCommand = value; }
		}

		private Command resetGameCommand;
		public Command ResetGameCommand
        {
			get { return resetGameCommand; }
			set { resetGameCommand = value; }
		}
        #endregion

        public DiceViewModel()
        {
			Dice1 = Dice2 = Dice3 = Dice4 = Dice5 = "question.jpg";
			ResultOfTheGame = $"Wynik gry: ";
            RollResult = $"Wynik tego losowania: ";
            RollDiceCommand = new Command(RollDice);
            ResetGameCommand = new Command(ResetGame);
        }

        int mainGameResult = 0;

        private string[] diceImages =
        {
            "k1.jpg",
            "k2.jpg",
            "k3.jpg",
            "k4.jpg",
            "k5.jpg",
            "k6.jpg",
        };

        public void RollDice()
        {
            Random rand = new Random();
            int[] diceValues = 
            {
                rand.Next(1,7),
                rand.Next(1,7),
                rand.Next(1,7),
                rand.Next(1,7),
                rand.Next(1,7)
            };

            Dice1 = diceImages[diceValues[0] - 1];
            Dice2 = diceImages[diceValues[1] - 1];
            Dice3 = diceImages[diceValues[2] - 1];
            Dice4 = diceImages[diceValues[3] - 1];
            Dice5 = diceImages[diceValues[4] - 1];

            var repetitions = diceValues.GroupBy(x => x).Where(g => g.Count() > 1).SelectMany(g => g);
            int throwResult = repetitions.Sum();

            mainGameResult += throwResult;
            RollResult = $"Wynik tego losowania: {throwResult}";
            ResultOfTheGame = $"Wynik całej gry: {mainGameResult}";
        }

		public void ResetGame()
		{
            Dice1 = Dice2 = Dice3 = Dice4 = Dice5 = "question.jpg";
            mainGameResult = 0;
            ResultOfTheGame = $"Wynik gry: {mainGameResult}";
        }
    }
}
