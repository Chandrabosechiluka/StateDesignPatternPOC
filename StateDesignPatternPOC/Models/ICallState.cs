using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public interface ICallState
    {
        void Dial(PhoneCall call);
        void Answer(PhoneCall call);
        void Hold(PhoneCall call);
        void End(PhoneCall call);
    }

}
