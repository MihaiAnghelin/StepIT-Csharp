using System.Collections.Generic;

namespace Final_Exam
{
    class Profesor : Om
    {
        private List<string> _numeLicee=new List<string>();
        private Materie _materie;

        public Profesor(string name, int age, string address, Materie materie) : base(name, age, address)
        {
            _materie = materie;
        }

        public void AddLiceu(string liceu)
        {
            _numeLicee.Add(liceu);
        }

        public List<string> NumeLicee
        {
            get { return _numeLicee; }
            set { _numeLicee = value; }
        }

        public Materie Materie1
        {
            get { return _materie; }
            set { _materie = value; }
        }

        public override string ToString()
        {
            string licee = "";
            foreach (var liceu in _numeLicee)
            {
                licee += (liceu + " ");
            }

            return "Nume: " + base.Name + "\nVarsta: " + base.Age + "\nAdresa: " + base.Address + "\nLicee: " + licee +
                   "\nMaterie: " + _materie;
        }
    }
}