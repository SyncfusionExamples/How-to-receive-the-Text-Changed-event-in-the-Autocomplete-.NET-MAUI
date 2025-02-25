using Syncfusion.Maui.Inputs;

namespace AutoCompleteTextChanged
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Get the Entry control from SfAutocomplete
            var entry = GetEntryFromAutocomplete(autoComplete);
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

        private Entry? GetEntryFromAutocomplete(SfAutocomplete sfAutocomplete)
        {
            foreach (var child in sfAutocomplete.Children)
            {
                if (child is Entry entry)
                {
                    return entry;
                }
            }
            return null; // Return null if no Entry is found
        }

    }

}
