using System;
using System.Collections.Generic;

namespace Final_Exam
{
    class Liceu
    {
        private static int _id = 0;
        private int _personalId;
        private string _nume;
        private int _numarClase;
        private List<Om> _membrii = new List<Om>();

        public Liceu(string nume, int numarClase, List<Om> membrii)
        {
            _personalId = _id++;
            _nume = nume;
            _numarClase = numarClase;
            _membrii = membrii;
        }

        public Liceu(string nume, int numarClase)
        {
            _personalId = _id++;
            _nume = nume;
            _numarClase = numarClase;
        }

        public void AddMember(Om om)
        {
            if (om is Profesor profesor)
            {
                profesor.AddLiceu(_nume);
            }

            if (om is Elev elev)
            {
                elev.Liceu = _nume;
            }
            _membrii.Add(om);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Nume liceu: " + _nume + "\nID: " + _personalId + "\nNumar de clase: " + _numarClase);
            Console.WriteLine("--------------------");
            foreach (var membru in _membrii)
            {
                switch (membru)
                {
                    case Elev _:
                        Console.WriteLine("\nElev: \n" + membru.ToString());
                        break;
                    case Profesor _:
                        Console.WriteLine("\nProfesor: \n" + membru.ToString());
                        break;
                }
            }
        }

        public Om this[int ind] => _membrii?[ind];
    }
}