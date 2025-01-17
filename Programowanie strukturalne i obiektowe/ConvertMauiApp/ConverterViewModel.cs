using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMauiApp
{
    public class ConverterViewModel : BindableObject
    {
        #region props
        public List<string> Units { get; set; }
        public string SelectedUnit { get; set; }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }
        public string UnitToChange { get; set; }
        private Command convertCommand;
        public  Command ConvertCommand
        {
            get { return convertCommand; }
            set { convertCommand = value; }
        }
        #endregion

        public ConverterViewModel()
        {
            Units = new List<string>();
            ConvertCommand = new Command(Convert);

            Units.Add("celsjusza");
            Units.Add("farenheit");

            SelectedUnit = Units.First();
        }

        private void Convert()
        {
            double.TryParse(UnitToChange, out double unitToChange);
            double result;

            switch (SelectedUnit)
            {
                case "celsjusza":
                    result = Calculate("c", unitToChange);
                    ShowMessage(result, "farenheita");
                    break;
                case "farenheit":
                    result = Calculate("f", unitToChange);
                    ShowMessage(result, "celsjusza");
                    break;
                default:
                    break;
            }
        }

        private void ShowMessage(double value, string unit)
        {
            Message = $"Przeliczono na {value} {unit}";
        }

        private double Calculate(string unit, double value)
        {
            switch (unit)
            {
                case "c":
                    value = 2 * (value - 0.1 * value) + 32;
                    break;
                case "f":
                    value = ((value - 32) / 2) * 1.1;
                    break;
                default:
                    break;
            }
            return value;
        }
    }
}
