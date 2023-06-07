using System;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace UVTQuestions
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		private List<Question> _questions = new List<Question>();

        [ObservableProperty]
        private Question _currentQuestion;

        [ObservableProperty]
        private string _answered;

		public MainViewModel()
		{

			_questions.Add(new Question {
				QuestionTitle = "Care dintre următoarele afirmaţii este/sunt adevărată/adevărate pentru algoritmul corespunzător funcţiei de mai jos (se consideră că x este un tablou unidimensional cu n elemente)?",
				Answer1 = "Algoritmul returnează numărul de elemente pozitive din x",
				Answer2 = "Algoritmul returnează numărul de elemente din cea mai lungă subsecvenţă cu elemente pozitive din x",
				Answer3 = "Algoritmul are ordinul de complexitate O(n^2)",
				Answer4 = "Algoritmul are ordinul de complexitate O(n)",
				Answer = "b,d",
				Category = "Algoritmi si structuri de date"
            });
            _questions.Add(new Question
            {
                QuestionTitle = "Care dintre următoarele afirmaţii este/sunt adevărată/adevărate pentru algoritmul corespunzător funcţiei de mai jos (se consideră că x este un tablou unidimensional cu n elemente)?",
                Answer1 = "Algoritmul returnează numărul de elemente pozitive din x",
                Answer2 = "Algoritmul returnează numărul de elemente din cea mai lungă subsecvenţă cu elemente pozitive din x",
                Answer3 = "Algoritmul are ordinul de complexitate O(n^2)",
                Answer4 = "Algoritmul are ordinul de complexitate O(n)",
                Answer = "b,d",
                Category = "Algoritmi si structuri de date"
            });
            _questions.Add(new Question
            {
                QuestionTitle = "Care dintre următoarele afirmaţii este/sunt adevărată/adevărate pentru algoritmul corespunzător funcţiei de mai jos (se consideră că x este un tablou unidimensional cu n elemente)?",
                Answer1 = "Algoritmul returnează numărul de elemente pozitive din x",
                Answer2 = "Algoritmul returnează numărul de elemente din cea mai lungă subsecvenţă cu elemente pozitive din x",
                Answer3 = "Algoritmul are ordinul de complexitate O(n^2)",
                Answer4 = "Algoritmul are ordinul de complexitate O(n)",
                Answer = "b,d",
                Category = "Algoritmi si structuri de date"
            });
            Questions.Add(new Question
            {
                QuestionTitle = "Care dintre următoarele afirmaţii este/sunt adevărată/adevărate pentru algoritmul corespunzător funcţiei de mai jos (se consideră că x este un tablou unidimensional cu n elemente)?",
                Answer1 = "Algoritmul returnează numărul de elemente pozitive din x",
                Answer2 = "Algoritmul returnează numărul de elemente din cea mai lungă subsecvenţă cu elemente pozitive din x",
                Answer3 = "Algoritmul are ordinul de complexitate O(n^2)",
                Answer4 = "Algoritmul are ordinul de complexitate O(n)",
                Answer = "b,d",
                Category = "Algoritmi si structuri de date"
            });

            LoadQuestion();
            string json = JsonSerializer.Serialize<List<Question>>(_questions);
        }

		private void LoadQuestionsFromJson(string json)
		{
			List<Question> questions = JsonSerializer.Deserialize<List<Question>>(json);
		}

        private void LoadQuestion()
        {
            CurrentQuestion = _questions.FirstOrDefault();
        }
        private void NextQuestion()
        {

        }

        [RelayCommand]
        public async Task AnswerQuestionAsync()
        {
            if(Answered == _currentQuestion.Answer)
            {
                NextQuestion();
            }
            else
            {
                CurrentQuestion.QuestionTitle = "WRONG";
            }
        }
	}
}

