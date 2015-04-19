using System;
using ChuckNorris;
using Xamarin.Forms;

namespace ChuckNorrisForms
{
    public partial class WelcomePage : ContentPage
    {
        private readonly ChuckNorrisQuotes _chuckNorrisQuotes = new ChuckNorrisQuotes();
        private readonly QuoteViewModel _quoteViewModel = new QuoteViewModel();

        public WelcomePage()
        {
            InitializeComponent();
            _quoteViewModel.CurrentQuote = GetNextQuote();
            BindingContext = _quoteViewModel;
//            BindingContext = _quoteViewModel;
        }

        private string GetNextQuote()
        {
            return _chuckNorrisQuotes.GetNextQuote();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            _quoteViewModel.CurrentQuote = GetNextQuote();
        }
    }
}
