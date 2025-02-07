using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzMauiApp
{
    internal class QuizzViewModel : BindableObject
    {
		private string question;

		public string Question
		{
			get { return question; }
			set { question = value; OnPropertyChanged(); }
		}

	}
}
