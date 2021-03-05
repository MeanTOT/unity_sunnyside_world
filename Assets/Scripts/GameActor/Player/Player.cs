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
    }

    public class Player : GameActor
    {
        public PlayerStateContainer States;

        public Animator Animator { get; private set; } = null;
        public Rigidbody2D Rb2D { get; private set; } = null;
        public InteractionDetector InteractionDetector { get; private set; } = null;
        public InteractionHandler InteractionHandler { get; private set; } = null;

        private StateMachine mSM;

        private void Awake()
        {
            Animator = this.GetComponent<Animator>();
            Rb2D = this.GetComponent<Rigidbody2D>();
            InteractionDetector = this.GetComponentInChildren<InteractionDetector>();
            InteractionHandler = this.GetComponentInChildren<InteractionHandler>();
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

        public void DoInteraction()
        {
            InteractionDetector.GetInteraction().Interaction();
        }

        private void InitStatesInternal()
        {
            mSM = new StateMachine();            
            States.Idle = new PlayerState_Idle(this, mSM);
            States.Walk = new PlayerState_Walk(this, mSM);
            States.Run = new PlayerState_Run(this, mSM);
            States.Axe = new PlayerState_Axe(this, mSM);
            mSM.Init(States.Idle);
        }
    }
}