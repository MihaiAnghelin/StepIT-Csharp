namespace Final_Exam
{
    class Om
    {
        private string _name;
        private int _age;
        private string _address;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Om(string name, int age, string address)
        {
            _name = name;
            _age = age;
            _address = address;
        }
    }
}