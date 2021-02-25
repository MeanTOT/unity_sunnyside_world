using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class State
    {        
        public StateMachine SM;

        protected State(GameActor gameActor, StateMachine stateMachine)
        {            
            this.SM = stateMachine;
        }

        public abstract void Enter();
        public abstract void LogicUpdate();
        public abstract void PhysicsUpdate();
        public abstract void Exit();
    }
}
