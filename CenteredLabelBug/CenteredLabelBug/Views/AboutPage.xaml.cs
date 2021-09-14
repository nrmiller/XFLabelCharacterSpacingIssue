using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CenteredLabelBug.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            SetFromCSharp.Text = "THIS\nIS\nMULTI-LINE\nTEXT\n\\n ONLY";
            SetFromCSharp2.Text = "THIS\r\nIS\r\nMULTI-LINE\r\nTEXT\r\n\\r\\n";
            SetFromStringRes.Text = Strings.MultilineText;
        }
    }
}