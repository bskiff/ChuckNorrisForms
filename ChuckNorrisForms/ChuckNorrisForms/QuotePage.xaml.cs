using System;
using ChuckNorris;
using Xamarin.Forms;

namespace ChuckNorrisForms
{
    public partial class QuotePage : ContentPage
    {
        private readonly QuoteViewModel _quoteViewModel = new QuoteViewModel();

        public QuotePage()
        {
            InitializeComponent();
            BindingContext = _quoteViewModel;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            _quoteViewModel.NextQuote();
        }
    }
}
