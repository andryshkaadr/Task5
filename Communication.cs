namespace Task5
{
    public class Communication
    {
        private string _message;
        private string _author;
        private string _communicationChannel;
        private DateTime _dateTime;
        private string _context;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string CommunicationChannel
        {
            get { return _communicationChannel; }
            set { _communicationChannel = value; }
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public string Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public Communication(string message, string author, string communicationChannel, DateTime dateTime, string context)
        {
            _message = message;
            _author = author;
            _communicationChannel = communicationChannel;
            _dateTime = dateTime;
            _context = context;
        }

        public override string ToString()
        {
            return $"Message: {_message}\nAuthor: {_author}\nCommunication Channel: {_communicationChannel}\nDate and Time: {_dateTime}\nContext: {_context}\n";
        }
    }
}