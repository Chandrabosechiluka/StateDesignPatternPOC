using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public class OnHoldState : ICallState
    {
        public void Dial(PhoneCall call) => Console.WriteLine("Cannot dial while on hold.");

        public void Answer(PhoneCall call)
        {
            Console.WriteLine("Resuming call from hold.");
            call.SetState(new ConnectedState());
        }

        public void Hold(PhoneCall call) => Console.WriteLine("Call is already on hold.");

        public void End(PhoneCall call)
        {
            Console.WriteLine("Call ended.");
            call.SetState(new EndedState());
        }
    }

}
