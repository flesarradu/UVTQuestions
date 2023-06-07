using System;
using System.ComponentModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UVTQuestions.Services
{
	public partial class QuestionService : IQuestionService
	{
        public const string QuestionsPath = "questions.json";

        private IEnumerator<Question> questionEnumerator;

		public QuestionService()
		{
            Questions = GetQuestions();

            Questions = Questions.OrderBy(x => new Random().Next()).ToList();
            questionEnumerator = Questions.GetEnumerator();
		}

        public List<Question> Questions { get; set; }

        public List<Question> GetQuestions()
        {
            return JsonSerializer.Deserialize<List<Question>>(File.ReadAllText(QuestionsPath));
        }

        public Question GetQuestion()
        {
            if (questionEnumerator.MoveNext())
            {
                return questionEnumerator.Current;
            }

            return null;
        }
    }
}

