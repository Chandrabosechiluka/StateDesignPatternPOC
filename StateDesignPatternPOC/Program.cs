using StateDesignPatternPOC.Models;

namespace StateDesignPatternPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneCall call = new PhoneCall();

            call.Dial();   
            call.Answer();  
            call.Hold();    
            call.Answer(); 
            call.End();
        }
    }
}
