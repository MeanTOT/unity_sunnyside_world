using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class Flip  
    {
        public void Execute(Transform target, int dir)
        {
            if (dir == 1)
            {
                target.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            }
            else if (dir == -1)
            {
                target.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
            }
        }
    }
}
