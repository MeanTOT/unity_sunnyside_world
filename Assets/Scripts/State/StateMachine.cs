using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class StateMachine
    {        
        public State State { get; private set; }

        public void Init(State state)
        {
            State = state;
            state.Enter();
        }

        public void ChangeState(State newState)
        {
            State.Exit();

            State = newState;
            newState.Enter();
        }

        public void ChangeAnimation(Animator animator, string animationName)
        {
            animator.Play(animationName, -1, 0.0f);
        }
    }
}
