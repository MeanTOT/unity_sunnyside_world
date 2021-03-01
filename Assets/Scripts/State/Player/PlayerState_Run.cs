using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Run : PlayerState
    {
        public PlayerState_Run(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, ANIM_RUN);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            Player.DoRun(InputHandler.MoveValue);
            Player.DoFlip((int)InputHandler.MoveValue.x);

            if (!InputHandler.IsHorizontalPerformed && !InputHandler.IsVerticalPerformed)
            {
                SM.ChangeState(Player.States.Idle);
            }
            else if (!InputHandler.IsRunPerformed) 
            {
                SM.ChangeState(Player.States.Walk);
            }
            else if (InputHandler.IsUseToolPerformed)
            {
                SM.ChangeState(Player.States.UseTool);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
