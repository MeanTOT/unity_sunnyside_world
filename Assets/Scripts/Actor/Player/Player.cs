using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class Player : Actor
    {
        public struct StateContainer
        {
            public PlayerState_Idle Idle;
            public PlayerState_Walk Walk;
            public PlayerState_Run Run;
            public PlayerState_Axe Axe;
        }

        public struct ActionContainer
        {
            public Move Move;
            public Flip Flip;
        }

        public StateContainer States;
        public ActionContainer Actions;

        public Animator Animator { get; private set; } = null;
        public Rigidbody2D Rb2D { get; private set; } = null;

        private StateMachine mSM;

        private void Awake()
        {
            Animator = this.GetComponent<Animator>();
            Rb2D = this.GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            InitStatesInternal();
            InitActionsInternal();
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
            mSM.Init(States.Idle);
        }
        
        private void InitActionsInternal()
        {
            Actions.Move = new Move();
            Actions.Flip = new Flip();
        }

        private void DoInteractionEventInternal()
        {
            Locator.InteractionHandler.DoInteraction();
        }
    }
}