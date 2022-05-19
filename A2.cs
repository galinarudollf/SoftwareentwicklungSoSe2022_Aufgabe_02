using System;

namespace Aufgaben02
{
    enum Kategorie{Thermisch, Elektrisch, None}
    class Energiewesen
    {
        private string bezeichnung;
        private int regnummer;
        private Kategorie kategorie;
        private double leistung;
        //public string Bezeichnung(){get;set;}
        public string GetBezeichnung(){return bezeichnung;}
        public void SetBezeichnung(string bezeichnung){this.bezeichnung=bezeichnung;}
        public int GetRegnummer(){return regnummer;}
        public void SetRegnummer(int regnummer){this.regnummer=regnummer;}
        public Kategorie GetKategorie(){return kategorie;}
        public void SetKategorie(Kategorie kategorie){this.kategorie=kategorie;}
        public double GetLeiistung(){return leistung;}
        public void SetLeistung(double leistung){this.leistung=leistung;}
        public Energiewesen()
        {
            bezeichnung="";regnummer=0;kategorie=Kategorie.None;leistung=0.0;
        }
        public Energiewesen(string bezeichnung,int regnummer,Kategorie kategorie,double leistung)
        {
            this.bezeichnung=bezeichnung;
            this.regnummer=regnummer;
            this.kategorie=kategorie;
            this.leistung=leistung;
        }
        public void Print()
        {
            Console.WriteLine($"{bezeichnung} {regnummer} {kategorie} {leistung}");
        }
    }
    class A2
    {
        static void Main(string[] args)
        {
            Energiewesen e1=new Energiewesen();
            e1.SetBezeichnung("Etron");e1.SetKategorie(Kategorie.Elektrisch);
            e1.Print();
            Energiewesen t1=new Energiewesen("Cali",1,Kategorie.Thermisch,2.2);
            t1.Print();
        }
    }
}
