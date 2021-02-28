using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class GameActor : MonoBehaviour
    {
        float WalkSpeed = 3.0f;

        public void Walk(Vector2 value)
        {            
            Vector2 velocity = value * WalkSpeed * Time.deltaTime;
            this.transform.localPosition += new Vector3(velocity.x, velocity.y, 0.0f);
        }
    }
}