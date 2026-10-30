using RoomToRentRadar.Models;
using RoomToRentRadar.PageModels;

namespace RoomToRentRadar.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}