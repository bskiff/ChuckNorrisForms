using System;
using System.ComponentModel;
using ChuckNorrisQuotes;

namespace ChuckNorrisForms
{
    class QuoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ChuckNorrisQuoter _chuckNorrisQuoter = new ChuckNorrisQuoter();

        private String _currentQuote;

        public void NextQuote()
        {
            CurrentQuote = _chuckNorrisQuoter.GetNextQuote();
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
