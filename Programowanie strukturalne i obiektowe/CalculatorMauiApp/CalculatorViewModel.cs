using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMauiApp
{
    public class CalculatorViewModel : BindableObject
    {
        private string calculatingResult;
        public string CalculatingResult
        {
            get { return calculatingResult; }
            set { calculatingResult = value; OnPropertyChanged(); }
        }

        private Command numberCommand;
        public Command NumberCommand
        {
            get
            {
                if (numberCommand == null)
                    numberCommand = new Command<string>((string number) =>
                    {
                        if (ifOperationExcecute == false)
                            CalculatingResult += number;
                        else
                        { 
                            CalculatingResult = number;
                            ifOperationExcecute = false;
                        }
                    });
                return numberCommand;
            }
            set { numberCommand = value; }
        }

        private Command operationCommand;
        public Command OperationCommand
        {
            get
            {
                if (operationCommand == null)
                    operationCommand = new Command<string>((string operatorSign) =>
                    {
                        if (ifOperationExcecute)
                            return;

                        int firstNumber = prevNumber;
                        int secondNumber = int.Parse(calculatingResult);
                        CalculatingResult = GetOperationResult(prevOperatorSign, firstNumber, secondNumber).ToString();
                        prevOperatorSign = operatorSign;
                        prevNumber = int.Parse(calculatingResult);
                        ifOperationExcecute = true;
                    });
                return operationCommand;
            }
            set { operationCommand = value; }
        }

        private string prevOperatorSign = "+";
        private int prevNumber = 0;
        private bool ifOperationExcecute = false;

        int GetOperationResult(string operationSign, int firstNumber, int secondNumber)
        {
            int result = operationSign switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => secondNumber * firstNumber,
                "/" => secondNumber / firstNumber,
                _ => 0,
            };
            return result;
        }
    }
}
