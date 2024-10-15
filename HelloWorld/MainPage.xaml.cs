using System;
using Microsoft.Maui.Controls;
namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку
        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Изменяем текст в Label
            helloLabel.Text= "Hello, World!";
        }
    }

}
