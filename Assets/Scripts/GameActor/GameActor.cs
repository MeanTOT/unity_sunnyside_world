using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class GameActor : MonoBehaviour
    {
        public GameActorData Data;

        public void DoWalk(Vector2 value)
        {            
            Vector2 velocity = value * Data.WalkSpeed * Time.deltaTime;
            this.transform.localPosition += new Vector3(velocity.x, velocity.y, 0.0f);
        }

        public void DoRun(Vector2 value)
        {
            Vector2 velocity = value * Data.RunSpeed * Time.deltaTime;
            this.transform.localPosition += new Vector3(velocity.x, velocity.y, 0.0f);
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