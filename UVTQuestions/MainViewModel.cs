using System;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using UVTQuestions.Messages;
using UVTQuestions.Services;

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

        private IQuestionService _questionService;

		public MainViewModel(IQuestionService questionService)
		{
            _questionService = questionService;
            Questions = questionService.Questions;
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            CurrentQuestion = _questionService.GetQuestion();
        }
        private void NextQuestion()
        {
            CurrentQuestion = _questionService.GetQuestion();
        }

        [RelayCommand]
        public async Task AnswerQuestionAsync()
        {
            WeakReferenceMessenger.Default.Send<GetCheckedAnswersMessage>(new GetCheckedAnswersMessage(""));
            if(Answered == _currentQuestion.Answer)
            {
                NextQuestion();
            }
            else
            {
                Vibration.Vibrate(100);
            }
        }
	}
}

