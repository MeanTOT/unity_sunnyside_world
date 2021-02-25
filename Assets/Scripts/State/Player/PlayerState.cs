using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState : State
    {
        public const string STATE_IDLE = "Idle";
        public const string STATE_WALK = "Walk";
        public Player Player;

        public PlayerState(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
            this.Player = (Player)gameActor;            
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