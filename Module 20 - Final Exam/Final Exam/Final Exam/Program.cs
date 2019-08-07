using System;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor1 = new Profesor("Adi",37,"Strada Unirii",Materie.Biologie);
            Profesor profesor2 = new Profesor("Elena",27,"Strada Lalelelor",Materie.Informatica);
            Profesor profesor3 = new Profesor("Vali",27,"Strada Lalelelor",Materie.Logica);
            Profesor profesor4 = new Profesor("Laurentiu", 37, "Strada Unirii", Materie.Chimie);

            Elev elev1 = new Elev("Andrei",18,"Strada Garoafelor",Clasa.doisprezeceA);
            Elev elev2 = new Elev("Andeea",17,"Strada Ghioceilor",Clasa.doisprezeceC);
            Elev elev3 = new Elev("Matei",17,"Strada Zambilelor",Clasa.nouaB);
            Elev elev4 = new Elev("Tudor",16,"Strada Zambilelor",Clasa.unsprezeceC);
            Elev elev5 = new Elev("Luca",15,"Strada Trandafirilor",Clasa.unsprezeceC);
            Elev elev6 = new Elev("Vlad",18,"Strada Beethoven",Clasa.doisprezeceA);



            Liceu liceu1 = new Liceu("Caragiale", 40);
            Liceu liceu2 = new Liceu("Sava", 30);

            liceu1.AddMember(profesor1);
            liceu1.AddMember(profesor2);
            liceu1.AddMember(elev1);
            liceu1.AddMember(elev2);
            liceu1.AddMember(elev3);
            liceu1.AddMember(elev4);
            liceu1.AddMember(elev5);
            liceu1.AddMember(elev6);
            
            liceu2.AddMember(profesor1);
            liceu2.AddMember(profesor3);
            liceu2.AddMember(profesor4);
            
            liceu1.PrintInfo();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            liceu2.PrintInfo();

            Console.WriteLine("Hello World!");
        }
    }
}
