namespace Task5
{
    public class Speech : Communication
    {
        private string _language;
        private int _duration;
        private string _topic;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        public Speech(string message, string author, string communicationChannel, DateTime dateTime, string context, string language, int duration, string topic)
            : base(message, author, communicationChannel, dateTime, context)
        {
            _language = language;
            _duration = duration;
            _topic = topic;
        }

        public override string ToString()
        {
            return base.ToString() + $"Language: {_language}\nDuration: {_duration} minutes\nTopic: {_topic}\n";
        }
    }
}