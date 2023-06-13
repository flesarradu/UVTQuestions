using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UVTQuestions
{
	public partial class Question : ObservableObject
	{
        [ObservableProperty]
		private List<string> _answers;
        [ObservableProperty]
        private List<QuestionParameter> _answers2;
		public string QuestionTitle { get; set; }
        
		public string Answer1 { get; set; }
		public string Answer2 { get; set; }
		public string Answer3 { get; set; }
		public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Answer6 { get; set; }
        public string Answer7 { get; set; }
        public string Answer8 { get; set; }
        public string Answer9 { get; set; }
        public string Answer10 { get; set; }
        public string Answer { get; set; }
		public string Category { get; set; }
		public string Image { get; set; }

        public Question()
        {
            SetAnswers();
        }

        public void SetAnswers()
        {
            Answers2 = new();
            List<string> answerInputs = new List<string> { Answer1, Answer2, Answer3, Answer4, Answer5, Answer6, Answer7, Answer8, Answer9, Answer10 };

            foreach (string answerInput in answerInputs)
            {
                if (!string.IsNullOrEmpty(answerInput))
                {
                    Answers2.Add(new QuestionParameter { Text = answerInput, IsChecked = false });
                }
            }

        }

    }
}

