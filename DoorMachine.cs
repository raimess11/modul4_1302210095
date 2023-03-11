using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace tpmodul4_1302210095
{
    internal class DoorMachine
    {
        public DoorState currentState;
        public enum DoorState { TERBUKA, TERKUNCI};
        public enum Trigger { BUKAPINTU, KUNCIPINTU};
        class Transition
        {
            public DoorState prevState;
            public DoorState nextState;
            public Trigger trigger;
            public Transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
        Transition[] transitions =
        {
            new Transition(DoorState.TERBUKA,DoorState.TERKUNCI,Trigger.KUNCIPINTU),
            new Transition(DoorState.TERKUNCI,DoorState.TERKUNCI,Trigger.KUNCIPINTU),
            new Transition(DoorState.TERKUNCI,DoorState.TERBUKA,Trigger.BUKAPINTU),
            new Transition(DoorState.TERBUKA,DoorState.TERBUKA,Trigger.BUKAPINTU),
        };
        public DoorState getNextState(DoorState prevState, Trigger trigger)
        {
            DoorState nextState = prevState;
            foreach(Transition transition in transitions){
                if(transition.prevState == prevState && transition.trigger == trigger)
                {
                    nextState = transition.nextState;
                }
            }
            return nextState;
        }
        public void activeTrigger(Trigger trigger)
        {
            DoorState nextState = getNextState(currentState, trigger);
            currentState = nextState;

            Console.WriteLine("PINTU " + ((currentState == DoorState.TERKUNCI) ? "TERKUNCI":"TIDAK TERKUNCI"));
        }
    }
}
