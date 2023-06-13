using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UVTQuestions
{
	public partial class QuestionParameter : ObservableObject
	{
		[ObservableProperty]
		private string _text;
		[ObservableProperty]
		private bool _isChecked;
	}
}

