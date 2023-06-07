using System;
namespace UVTQuestions
{
    public static partial class MauiProgram
    {
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<MainViewModel>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<MainPage>();

            return mauiAppBuilder;
        }
    }
}

