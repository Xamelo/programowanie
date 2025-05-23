﻿using System.Collections.ObjectModel;

namespace RecalculationMauiApp
{
    public partial class MainPage : ContentPage
    {
        #region props
        public Collection<string> UnitsCollection { get; set; }
        public string SelectedUnit { get; set; }
        public string SelectedUnitToChange { get; set; }
        public string UnitToChange { get; set; }
        private string unitMessage;

        public string UnitMessage
        {
            get { return unitMessage; }
            set
            { 
                unitMessage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainPage()
        {
            UnitsCollection = new Collection<string>();
            UnitsCollection.Add("mm");
            UnitsCollection.Add("cm");
            UnitsCollection.Add("dm");
            UnitsCollection.Add("m");
            UnitsCollection.Add("km");

            SelectedUnit = UnitsCollection.First();
            SelectedUnitToChange = UnitsCollection.First();

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double.TryParse(UnitToChange, out double unitToChange);

            switch (SelectedUnitToChange)
            {
                case "mm":
                    ShowMessage(ChangeToMilimeters(unitToChange, SelectedUnit));
                    break;
                case "cm":
                    ShowMessage(ChangeToMilimeters(unitToChange, SelectedUnit) / 10);
                    break;
                case "dm":
                    ShowMessage(ChangeToMilimeters(unitToChange, SelectedUnit) / 100);
                    break;
                case "m":
                    ShowMessage(ChangeToMilimeters(unitToChange, SelectedUnit) / 1000);
                    break;
                case "km":
                    ShowMessage(ChangeToMilimeters(unitToChange, SelectedUnit) / 1000000);
                    break;
                default:
                    break;
            }
        }

        private double ChangeToMilimeters(double value, string unit)
        {
            switch (unit)
            {
                case "mm":
                    return value;
                case "cm":
                    value *= 10;
                    break;
                case "dm":
                    value *= 100;
                    break;
                case "m":
                    value *= 1000;
                    break;
                case "km":
                    value *= 1000000;
                    break;
                default:
                    break;
            }
            return value;
        }

        private void ShowMessage(double value)
        {
            UnitMessage = $"Przeliczono na: {value}";
        }
    }

}
