using System;

public class Smartphone
{
    private int? pin;
    private int count;
    private bool blocked;

    public Smartphone()
    {
        pin=null;
        count=0;
        blocked=false;
    }

    private bool authenticate()
    {
        if (pin==null)
        {
            Console.WriteLine("Keine Auth. notwendig"); 
            return true;
        }
        if (blocked==true) 
        {
            Console.WriteLine("Smartphone gesperrt"); return false;
        }
            
        int eingabe;
        do {
            Console.WriteLine("Pin?");
            Int32.TryParse(Console.ReadLine(),out eingabe);
            if (eingabe==pin) {count=0; blocked=false; return true;}
            else
            {
                Console.WriteLine("Authentifizierungsfehler");
                count++;
            }
        }while (count<3);
        blocked=true; Console.WriteLine("Smartphone gesperrt");
        return false;
    }
    public void PinChange()
    {
        if (authenticate()==true)
        { 
            Console.WriteLine("neue Pin?");
            try
            {
                string neu=Console.ReadLine();
                if (neu.Equals(string.Empty))
                {
                    pin = null;
                }
                else pin=Int32.Parse(neu);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    static void Main(string[] args)
    {
        Smartphone phone = new Smartphone();
        phone.PinChange();
        phone.PinChange();
    }
}
