using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class PlayerState_Interaction : PlayerState
    {
        public PlayerState_Interaction(GameActor gameActor, StateMachine stateMachine) : base(gameActor, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            if (Player.InteractionDetector.GetInteraction().Type == EInteractionType.Axe)
                SM.ChangeState(Player.States.Axe);
            else
                SM.ChangeState(Player.States.Idle);
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
