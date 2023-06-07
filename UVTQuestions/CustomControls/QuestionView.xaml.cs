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
	public static BindableProperty QuestionTitleProperty = BindableProperty.Create(
		nameof(QuestionTitle),
		typeof(string),
		typeof(QuestionView),
		string.Empty);
    public static BindableProperty Answer1Property = BindableProperty.Create(
        nameof(Answer1),
        typeof(string),
        typeof(QuestionView),
        string.Empty);
    public static BindableProperty Answer2Property = BindableProperty.Create(
        nameof(Answer2),
        typeof(string),
        typeof(QuestionView),
        string.Empty);
    public static BindableProperty Answer3Property = BindableProperty.Create(
        nameof(Answer3),
        typeof(string),
        typeof(QuestionView),
        string.Empty);
    public static BindableProperty Answer4Property = BindableProperty.Create(
        nameof(Answer4),
        typeof(string),
        typeof(QuestionView),
        string.Empty);

    public static BindableProperty AnsweredProperty = BindableProperty.Create(
        nameof(Answer4),
        typeof(string),
        typeof(QuestionView),
        string.Empty,
        defaultBindingMode: BindingMode.TwoWay);


    public string Answered
    {
        get => (string)GetValue(AnsweredProperty);
        set => SetValue(AnsweredProperty, value);
    }
    public string QuestionTitle
	{
        get => (string)GetValue(QuestionTitleProperty);
        set => SetValue(QuestionTitleProperty, value);
    }
    public string Answer1
    {
        get => (string)GetValue(Answer1Property);
        set => SetValue(Answer1Property, value);
    }
    public string Answer2
    {
        get => (string)GetValue(Answer2Property);
        set => SetValue(Answer2Property, value);
    }
    public string Answer3
    {
        get => (string)GetValue(Answer3Property);
        set => SetValue(Answer3Property, value);
    }
    public string Answer4
    {
        get => (string)GetValue(Answer4Property);
        set => SetValue(Answer4Property, value);
    }

    public void GetCheckedAnswers()
    {
        List<string> checkedAnswers = new List<string>();

        if (checBox1.IsChecked)
        {
            checkedAnswers.Add("a");
        }
        if (checBox2.IsChecked)
        {
            checkedAnswers.Add("b");
        }
        if (checBox3.IsChecked)
        {
            checkedAnswers.Add("c");
        }

        if (checBox4.IsChecked)
        {
            checkedAnswers.Add("d");
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



