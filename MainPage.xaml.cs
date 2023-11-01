using My_Tasks.ViewModels;

namespace My_Tasks
{
    public partial class MainPage : ContentPage
    {       
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }
}