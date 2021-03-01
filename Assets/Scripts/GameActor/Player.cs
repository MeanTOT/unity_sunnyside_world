using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public struct PlayerStateContainer
    {
        public PlayerState_Idle Idle;
        public PlayerState_Walk Walk;
        public PlayerState_Run Run;
        public PlayerState_UseTool UseTool;
    }

    public class Player : GameActor
    {
        public PlayerStateContainer States;
        public Animator Animator = null;

        private StateMachine mSM;

        private void Awake()
        {

        }

        private void Start()
        {
            InitStatesInternal();
        }

        private void Update()
        {            
            mSM.State.LogicUpdate();            
        }

        private void FixedUpdate()
        {
            mSM.State.PhysicsUpdate();
        }

        private void InitStatesInternal()
        {
            mSM = new StateMachine();
            States.Idle = new PlayerState_Idle(this, mSM);
            States.Walk = new PlayerState_Walk(this, mSM);
            States.Run = new PlayerState_Run(this, mSM);
            States.UseTool = new PlayerState_UseTool(this, mSM);
            mSM.Init(States.Idle);
        }
    }
}