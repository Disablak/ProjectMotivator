using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMotivator
{
    class Quote
    {
        public string QuoteText { get; private set; }
        public string QuoteAuthor { get; private set; }

        public Quote(string text, string author)
        {
            QuoteText = text;
            QuoteAuthor = author;
        }
    }
}
