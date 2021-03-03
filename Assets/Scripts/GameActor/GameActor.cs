using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class GameActor : MonoBehaviour
    {
        public GameActorData Data;

        public void DoWalk(Vector2 value, Rigidbody2D rb2d)
        {

            Vector2 velocity = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y) + (value * Data.WalkSpeed);
            rb2d.MovePosition(velocity);            
        }

        public void DoRun(Vector2 value, Rigidbody2D rb2d)
        {
            Vector2 velocity = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y) + (value * Data.RunSpeed);
            rb2d.MovePosition(velocity);            
        }

        public void DoFlip(int dir)
        {
            if (dir == 1)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            }
            else if (dir == -1)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
            }
        }
    }
}