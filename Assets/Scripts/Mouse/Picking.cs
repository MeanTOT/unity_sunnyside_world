using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class Picking
    {
        private Ray2D mRay = default;

        public Picking()
        {

        }

        public RaycastHit2D GetHit()
        {
            mRay = new Ray2D(Locator.Input.GetMouseWorldPosition(), Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(mRay.origin, mRay.direction);

            return hit;
        }
    }
}
