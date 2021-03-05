using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Axe : PlayerState
    {
        public PlayerState_Axe(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, ANIM_AXE);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (Player.Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !Player.Animator.IsInTransition(0))
            {
                SM.ChangeState(Player.States.Idle);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
