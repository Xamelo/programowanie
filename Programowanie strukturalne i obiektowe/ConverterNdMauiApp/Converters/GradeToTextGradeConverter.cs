﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNdMauiApp.Converters
{
    class GradeToTextGradeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null || value is not string)
                throw new Exception("Błędna wartość");

            string grade = value as string;

            string textGrade = grade switch
            {
                "1" => "Niedostateczny",
                "2" => "Dopuszczający",
                "3" => "Dostateczny",
                "4" => "Dobry",
                "5" => "Bardzo dobry",
                "6" => "Celujący",
                "" => "",
                _ => "Blędne dane"
            };
            return textGrade;   
        }
        
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
