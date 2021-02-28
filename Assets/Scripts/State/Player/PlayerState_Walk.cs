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

            Debug.Log("Walk");
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            Player.Walk(InputManager.MoveDirection);

            if (!InputManager.IsHorizontalPerformed && !InputManager.IsVerticalPerformed)
            {
                SM.ChangeState(Player.Idle);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
