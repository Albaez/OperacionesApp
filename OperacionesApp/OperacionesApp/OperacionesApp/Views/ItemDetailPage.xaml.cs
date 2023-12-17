using System.ComponentModel;
using Xamarin.Forms;
using OperacionesApp.ViewModels;

namespace OperacionesApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}