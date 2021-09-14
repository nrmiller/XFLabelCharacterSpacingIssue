using CenteredLabelBug.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CenteredLabelBug.Views
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