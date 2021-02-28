using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Idle : PlayerState
    {
        public PlayerState_Idle(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, STATE_IDLE);            
        }

        public override void Exit()
        {
            base.Exit();            
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();            

            if (InputManager.IsHorizontalPerformed || InputManager.IsVerticalPerformed)
            {
                SM.ChangeState(Player.Walk);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
