using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using UVTQuestions.Messages;

namespace UVTQuestions.CustomControls;

/// <summary>
/// QuestionView.
/// </summary>
public partial class QuestionView : ContentView
{
    public static BindableProperty QuestionProperty = BindableProperty.Create(
        nameof(Question),
        typeof(Question),
        typeof(QuestionView),
        null);

    public static BindableProperty AnsweredProperty = BindableProperty.Create(
        nameof(Answered),
        typeof(string),
        typeof(QuestionView),
        string.Empty,
        defaultBindingMode: BindingMode.TwoWay);

    public Question Question
    {
        get => (Question)GetValue(QuestionProperty);
        set
        {
            SetValue(QuestionProperty, value);
        }
    }

    public string Answered
    {
        get => (string)GetValue(AnsweredProperty);
        set => SetValue(AnsweredProperty, value);
    }   

    public void GetCheckedAnswers()
    {
        List<string> checkedAnswers = new List<string>();

        char answer='a';
        foreach(QuestionParameter check in Question.Answers2)
        {
            if (check.IsChecked)
            {
                checkedAnswers.Add((answer).ToString());
                answer++;
            }
        }

        Answered = string.Join(',', checkedAnswers);
    }

    public QuestionView()
	{
		InitializeComponent();

        WeakReferenceMessenger.Default.Register<GetCheckedAnswersMessage>(this, (r, m) =>
        {
            GetCheckedAnswers();
        });
	}
}



