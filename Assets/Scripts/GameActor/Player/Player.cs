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
        public PlayerState_Axe Axe;
        public PlayerState_Interaction Interaction;
    }

    public class Player : GameActor
    {
        public Animator Animator = null;
        public PlayerStateContainer States;

        public InteractionDetector InteractionDetector { get; private set; }
        public Rigidbody2D Rb2D { get; private set; }

        private StateMachine mSM;

        private void Awake()
        {
            Rb2D = this.GetComponent<Rigidbody2D>();
            InteractionDetector = this.GetComponentInChildren<InteractionDetector>();
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
            States.Axe = new PlayerState_Axe(this, mSM);
            States.Interaction = new PlayerState_Interaction(this, mSM);
            mSM.Init(States.Idle);
        }
    }
}