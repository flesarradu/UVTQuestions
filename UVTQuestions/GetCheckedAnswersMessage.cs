using System;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace UVTQuestions.Messages
{
    public class GetCheckedAnswersMessage : ValueChangedMessage<string>
    {
        public GetCheckedAnswersMessage(string value)
            : base(value)
        {

        }
    }
}

