using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public abstract class GameActor : MonoBehaviour
    {
        public GameActorData Data;

        public LTDescr DoPixelWalk(Vector2 value)
        {
            return LeanTween.moveLocal(this.gameObject, this.transform.localPosition + new Vector3(value.x, value.y, 0.0f), 0.5f);
        }

        public LTDescr DoPixelRun(Vector2 value)
        {
            return LeanTween.moveLocal(this.gameObject, this.transform.localPosition + new Vector3(value.x, value.y, 0.0f), 0.3f);
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