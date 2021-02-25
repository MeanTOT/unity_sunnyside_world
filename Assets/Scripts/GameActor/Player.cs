using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class Player : GameActor
    {
        public PlayerState_Idle Idle;
        public PlayerState_Walk Walk;

        public Animator Animator = null;

        private StateMachine mSM;

        private void Start()
        {
            mSM = new StateMachine();

            Idle = new PlayerState_Idle(this, mSM);
            Walk = new PlayerState_Walk(this, mSM);

            mSM.Init(Idle);
        }

        private void Update()
        {
            mSM.State.LogicUpdate();            
        }

        private void FixedUpdate()
        {
            mSM.State.PhysicsUpdate();
        }
    }
}