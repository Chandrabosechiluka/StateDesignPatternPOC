using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public class ConnectedState : ICallState
    {
        public void Dial(PhoneCall call) => Console.WriteLine("Already connected. Cannot dial another number.");

        public void Answer(PhoneCall call) => Console.WriteLine("Call is already connected.");

        public void Hold(PhoneCall call)
        {
            Console.WriteLine("Call on hold.");
            call.SetState(new OnHoldState());
        }

        public void End(PhoneCall call)
        {
            Console.WriteLine("Call ended.");
            call.SetState(new EndedState());
        }
    }

}
