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

            Player.DoFlip((int)Locator.Input.HorizontalValue);

            if (Locator.Input.IsHorizontalPerformed)
            {
                this.Player.DoPixelRun(new Vector2(Locator.Input.HorizontalValue, 0.0f)).setOnComplete(() => SM.ChangeState(Player.States.Idle));
            }
            else if (Locator.Input.IsVerticalPerformed)
            {
                this.Player.DoPixelRun(new Vector2(0.0f, Locator.Input.VerticalValue)).setOnComplete(() => SM.ChangeState(Player.States.Idle));
            }
            else
            {
                SM.ChangeState(Player.States.Idle);
            }
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
