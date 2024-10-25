using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public class DialingState : ICallState
    {
        public void Dial(PhoneCall call) => Console.WriteLine("Already dialing...");

        public void Answer(PhoneCall call)
        {
            Console.WriteLine("Call connected.");
            call.SetState(new ConnectedState());
        }

        public void Hold(PhoneCall call) => Console.WriteLine("Cannot hold the call while dialing.");
        public void End(PhoneCall call)
        {
            Console.WriteLine("Call ended.");
            call.SetState(new EndedState());
        }
    }

}
