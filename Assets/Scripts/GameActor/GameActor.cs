using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class GameActor : MonoBehaviour
    {
        float MoveSpeed = 1.0f;

        public virtual void Move(Vector2 dir)
        {
            Vector2 velocity = dir * MoveSpeed * Time.deltaTime;
            this.transform.position += new Vector3(velocity.x, velocity.y, 0.0f);
        }
    }
}