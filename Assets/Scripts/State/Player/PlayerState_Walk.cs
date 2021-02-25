using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Walk : PlayerState
    {
        public PlayerState_Walk(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, STATE_WALK);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
