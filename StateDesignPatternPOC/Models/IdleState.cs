using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public class IdleState : ICallState
    {
        public void Dial(PhoneCall call)
        {
            Console.WriteLine("Dialing...");
            call.SetState(new DialingState());
        }

        public void Answer(PhoneCall call) => Console.WriteLine("No incoming call to answer.");
        public void Hold(PhoneCall call) => Console.WriteLine("No call to put on hold.");
        public void End(PhoneCall call) => Console.WriteLine("No active call to end.");
    }

}
