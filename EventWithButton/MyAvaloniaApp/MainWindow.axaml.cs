using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace MyAvaloniaApp
{
    public partial class MainWindow : Window
    {
        public event Action MyCustomEvent;

        public MainWindow()
        {
            InitializeComponent();
            MyCustomEvent += OnCustomEvent;
        }

        private void ClickButton_Click(object? sender, RoutedEventArgs e)
        {
            MyCustomEvent?.Invoke();
        }

        private void OnCustomEvent()
        {
            ShowMessageBox("Custom event triggered!");
        }

        private async void ShowMessageBox(string message)
        {
            var dialog = new Window
            {
                Width = 250,
                Height = 100,
                Content = new TextBlock
                {
                    Text = message,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
                }
            };

            await dialog.ShowDialog(this);
        }
    }
}
