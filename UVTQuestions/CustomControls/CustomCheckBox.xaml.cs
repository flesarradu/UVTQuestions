namespace UVTQuestions.CustomControls;

/// <summary>
/// CustomCheckBox control.
/// </summary>
public partial class CustomCheckBox : ContentView
{
    /// <summary>
    /// Sets the text of the label.
    /// </summary>
    public static BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(QuestionView),
        string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static BindableProperty IsCheckedProperty = BindableProperty.Create(
        nameof(IsChecked),
        typeof(bool),
        typeof(QuestionView),
        false);

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }
    public CustomCheckBox()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Changes the CheckBox state when clicked on the label to help user interaction.
    /// </summary>
    public void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        checkBox.IsChecked = !checkBox.IsChecked;
    }

    void checkBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        OnPropertyChanged(nameof(sender));
    }
}
