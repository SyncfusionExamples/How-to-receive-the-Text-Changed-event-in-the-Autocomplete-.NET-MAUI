namespace AutoCompleteTextChanged
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Get the Entry control from SfAutoComplete
            var entry = autoComplete.Children[1] as Entry;
            if (entry != null)
            {
                // Attach the TextChanged event handler
                entry.TextChanged += MainPage_TextChanged;
            }
        }

        private void MainPage_TextChanged(object? sender, TextChangedEventArgs e)
        {
            // Handle the text change event here
        }
    }

}
