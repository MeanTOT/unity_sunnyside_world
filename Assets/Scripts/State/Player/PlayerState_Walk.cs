using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Walk : PlayerState
    {
        public PlayerState_Walk(Actor actor, StateMachine stateMachine) : base(actor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SM.ChangeAnimation(Player.Animator, ANIM_WALK);

            Player.Actions.Flip.Execute(Player.transform, (int)Locator.Input.HorizontalValue);

            if (Locator.Input.IsHorizontalPerformed)
            {
                this.Player.Actions.Move.ExecuteByPixel(this.Player.transform, new Vector2(Locator.Input.HorizontalValue, 0.0f), this.Player.Data.WalkDuration).setOnComplete(() => SM.ChangeState(Player.States.Idle));
            }
            else if (Locator.Input.IsVerticalPerformed)
            {
                this.Player.Actions.Move.ExecuteByPixel(this.Player.transform, new Vector2(0.0f, Locator.Input.VerticalValue), this.Player.Data.WalkDuration).setOnComplete(() => SM.ChangeState(Player.States.Idle));
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
