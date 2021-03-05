using UnityEngine;

namespace Sunny
{
    public class Tree : NaturalObject
    {
        public override void Interaction()
        {
            base.Interaction();

            CurrentHp -= 1.0f;
            if (CurrentHp <= 0.0f)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Animator.Play(ANIM_BREAK, -1, 0.0f);
            }
        }
    }
}
