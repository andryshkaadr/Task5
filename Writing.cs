namespace Task5
{
    public class Writing : Communication
    {
        private string _documentType;
        private string _language;
        private int _pageCount;

        public string DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        public Writing(string message, string author, string communicationChannel, DateTime dateTime, string context, string documentType, string language, int pageCount)
            : base(message, author, communicationChannel, dateTime, context)
        {
            _documentType = documentType;
            _language = language;
            _pageCount = pageCount;
        }

        public override string ToString()
        {
            return base.ToString() + $"Document Type: {_documentType}\nLanguage: {_language}\nPage Count: {_pageCount}\n";
        }
    }
}
