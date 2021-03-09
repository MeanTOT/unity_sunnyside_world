using UnityEngine;

namespace Sunny
{
    public class Move
    {
        public LTDescr ExecuteByPixel(Transform target, Vector2 dir, float duration)
        {
            return LeanTween.moveLocal(target.gameObject, target.localPosition + new Vector3(dir.x, dir.y, 0.0f), duration);
        }
    }
}
