using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternPOC.Models
{
    public class PhoneCall
    {
        private ICallState _currentState;

        public PhoneCall()
        {
            _currentState = new IdleState();
        }

        public void SetState(ICallState newState)
        {
            _currentState = newState;
        }

        public void Dial() => _currentState.Dial(this);
        public void Answer() => _currentState.Answer(this);
        public void Hold() => _currentState.Hold(this);
        public void End() => _currentState.End(this);
    }

}
