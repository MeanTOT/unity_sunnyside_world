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

            SM.ChangeAnimation(Player.Animator, ANIM_WALK);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            
            Player.DoFlip((int)Locator.Input.MoveValue.x);

            if (!Locator.Input.IsHorizontalPerformed && !Locator.Input.IsVerticalPerformed)
            {
                SM.ChangeState(Player.States.Idle);
            }
            else if (Locator.Input.IsRunPerformed)
            {
                SM.ChangeState(Player.States.Run);
            }
            else if (Locator.Input.IsUseToolPerformed)
            {
                SM.ChangeState(Player.States.UseTool);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

            Player.DoWalk(Locator.Input.MoveValue, Player.Rb2D);                
        }        
    }
}
