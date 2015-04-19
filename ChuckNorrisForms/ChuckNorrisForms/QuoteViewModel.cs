using System;
using System.ComponentModel;
using ChuckNorris;

namespace ChuckNorrisForms
{
    class QuoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ChuckNorrisQuotes _chuckNorrisQuotes = new ChuckNorrisQuotes();

        private String _currentQuote;

        public void NextQuote()
        {
            CurrentQuote = _chuckNorrisQuotes.GetNextQuote();
        }

        public String CurrentQuote
        {
            get { return _currentQuote ?? String.Empty; }
            private set
            {
                if (_currentQuote != value)
                {
                    _currentQuote = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CurrentQuote"));
                    }
                }
            }
        }
    }
}
