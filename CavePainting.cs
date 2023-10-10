namespace Task5
{
    public class CavePainting : Communication
    {
        private string _location;
        private int _area;
        private string _style;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public string Style
        {
            get { return _style; }
            set { _style = value; }
        }

        public CavePainting(string message, string author, string communicationChannel, DateTime dateTime, string context, string location, int area, string style)
            : base(message, author, communicationChannel, dateTime, context)
        {
            _location = location;
            _area = area;
            _style = style;
        }

        public override string ToString()
        {
            return base.ToString() + $"Location: {_location}\nArea: {_area} square meters\nStyle: {_style}\n";
        }
    }
}