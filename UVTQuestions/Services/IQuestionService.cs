using System;
namespace UVTQuestions.Services
{
	public interface IQuestionService
	{
		public List<Question> Questions { get; set; }
        public List<Question> GetQuestions(string text);
		public Question GetQuestion();
    }
}

