using UnityEngine;

namespace Sunny
{    
    public class CursorHandler : MonoBehaviour
    {
        private SpriteRenderer mSR = null;
        private Sprite mDefault = null;        

        private void Awake()
        {
            mSR = this.GetComponent<SpriteRenderer>();
            mDefault = Resources.Load<Sprite>("Cursor/cursor_03");            
        }

        private void Start()
        {
            Cursor.visible = false;
        }

        private void Update()
        {
            FollowMouseInternal();
        }

        private void FollowMouseInternal()
        {
            this.transform.localPosition = Locator.Input.GetMouseWorldPosition();
        }
    }
}

