using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState : State
    {
        public const string ANIM_IDLE = "Idle";
        public const string ANIM_WALK = "Walk";
        public const string ANIM_RUN = "Run";
        public const string ANIM_AXE = "Axe";
        public Player Player;

        public PlayerState(Actor actor, StateMachine stateMachine) : base(actor, stateMachine)
        {
            this.Player = (Player)actor;            
        }

        public override void Enter()
        {

        }

        public override void Exit()
        {

        }

        public override void LogicUpdate()
        {

        }

        public override void PhysicsUpdate()
        {

        }
    }
}