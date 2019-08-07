using System.Buffers.Text;
using System.Reflection.Metadata.Ecma335;


namespace Final_Exam
{
    class Elev : Om
    {
        private string _liceu;
        private Clasa _clasaLiceu;

        public Elev(string name, int age, string address, Clasa clasa) : base(name, age, address)
        {
            _clasaLiceu = clasa;
        }

        public string Liceu
        {
            get { return _liceu; }
            set { _liceu = value; }
        }

        public Clasa ClasaLiceu
        {
            get { return _clasaLiceu; }
            set { _clasaLiceu = value; }
        }

        public override string ToString()
        {
            return "Nume: " + base.Name + "\nVarsta: " + base.Age + "\nAdresa: " + base.Address + "\nClasa: " + _clasaLiceu;
        }
    }
}