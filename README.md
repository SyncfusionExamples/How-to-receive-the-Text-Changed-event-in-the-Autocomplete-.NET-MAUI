# How to receive the Text Changed event in the .NET MAUI Autocomplete
This repository contains a sample explaining how to receive the Text Changed event in the Autocomplete .NET MAUIt
## Text Changed event in the Autocomplete .NET MAUI

we can use the TextChanged event from the Entry, which is a child element of the SfAutoComplete, and set up an event handler to respond to the text changes in the Entry element. Here’s how you can achieve this:

**C#**
```csharp
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
        // Get the Entry control from SfAutocomplete
        var entry = GetEntryFromAutoComplete(autoComplete);
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
```
