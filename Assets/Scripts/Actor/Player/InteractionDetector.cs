using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public class InteractionDetector : MonoBehaviour
    {
        private Vector2 mDetectionBoxSize = new Vector2(0.3f, 0.3f);
        private NullObject mNullObject = null;

        private void Awake()
        {
            mNullObject = new NullObject();
        }

        public bool CanMove()
        {
            Collider2D detectedCollider = null;

            if (Locator.Input.IsHorizontalPerformed)
            {
                detectedCollider = Physics2D.OverlapBox(this.transform.position + new Vector3(Locator.Input.HorizontalValue, 0.0f, 0.0f), mDetectionBoxSize, 0.0f);
            }
            else if (Locator.Input.IsVerticalPerformed)
            {
                detectedCollider = Physics2D.OverlapBox(this.transform.position + new Vector3(0.0f, Locator.Input.VerticalValue, 0.0f), mDetectionBoxSize, 0.0f);
            }
                
            return detectedCollider == null;
        }

        public Transform GetTargtOrNull()
        {
            Collider2D detectedCollider = null;

            detectedCollider = Physics2D.OverlapBox(this.transform.position + this.transform.parent.right, mDetectionBoxSize, 0.0f);

            if (detectedCollider)
            {
                return detectedCollider.transform;
            }

            return null;
        }

        public IInteraction GetInteraction()
        {
            Collider2D detectedCollider = null;

            detectedCollider = Physics2D.OverlapBox(this.transform.position + this.transform.parent.right, mDetectionBoxSize, 0.0f);

            if (detectedCollider != null && detectedCollider.GetComponent<IInteraction>() != null)
            {
                return detectedCollider.GetComponent<IInteraction>();
            }
            
            return mNullObject;
        }
    }
}
