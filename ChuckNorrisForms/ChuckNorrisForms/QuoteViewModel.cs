using System;
using System.ComponentModel;

namespace ChuckNorrisForms
{
    class QuoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private String _currentQuote;

        public String CurrentQuote
        {
            get { return _currentQuote ?? String.Empty; }
            set
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
