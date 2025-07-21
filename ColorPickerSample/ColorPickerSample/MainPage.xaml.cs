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
            colorPicker2.SelectedColor = e.NewColor;
        }

        private void OnColorSelected(object sender, ColorSelectedEventArgs e)
        {
            label.BackgroundColor = e.SelectedColor;
            label.Text = e.SelectedColor.ToHex();
        }
    }
}
