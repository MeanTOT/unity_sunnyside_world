using UnityEngine;

namespace Sunny
{
    public class Move
    {
        public void Execute(Rigidbody2D target, Vector2 dir, float speed)
        {
            target.MovePosition(new Vector2(target.transform.position.x, target.transform.position.y) + (dir * speed) * Time.deltaTime);
        }
    }
}
