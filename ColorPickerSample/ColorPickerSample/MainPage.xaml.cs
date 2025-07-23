using Syncfusion.Maui.Inputs;

namespace ColorPickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnColorChanging(object sender, ColorChangingEventArgs e)
        {
            colorPicker1.SelectedColor = e.NewColor;
        }

        private void OnColorChanged(object sender, ColorChangedEventArgs e)
        {
            
        }

        private void OnColorSelected(object sender, ColorSelectedEventArgs e)
        {
            label.Text = $"Selected: {e.SelectedColor.ToHex()}";
            label.BackgroundColor = e.SelectedColor;
            DisplayAlert("Color Selected", $"Color Selected: {e.SelectedColor.ToHex()}", "OK");
        }
    }
}
