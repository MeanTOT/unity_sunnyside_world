using UnityEngine;
using UnityEngine.InputSystem;

namespace Sunny
{
    public class InputHandler
    {
        private InputProvider mInputProvider = null;
        private InputActionMap mCurrentActionMap = null;

        public bool IsHorizontalPerformed { get; private set; }
        public bool IsVerticalPerformed { get; private set; }
        public bool IsRunPerformed { get; private set; }
        public bool IsUseToolPerformed { get; private set; }
        public Vector2 MoveValue
        { 
            get 
            {
                return new Vector2(mInputProvider.Play.Horizontal.ReadValue<float>(), mInputProvider.Play.Vertical.ReadValue<float>());
            }
        }

        public InputHandler()
        {
            InitInputProviderInternal();
            InitInputActionMapsInternal();
            InitActionEventsInternal();
        }

        public Vector2 GetMouseScreenPosition()
        {
            return mInputProvider.Play.MousePosition.ReadValue<Vector2>();
        }

        public Vector2 GetMouseWorldPosition()
        {
            return Camera.main.ScreenToWorldPoint(mInputProvider.Play.MousePosition.ReadValue<Vector2>());
        }

        private void InitInputProviderInternal()
        {
            if (mInputProvider == null)
                mInputProvider = new InputProvider();

            mInputProvider.Enable();            
            Application.quitting += () => mInputProvider.Disable();
        }

        private void InitInputActionMapsInternal()
        {
            mCurrentActionMap = mInputProvider.Play;
        }

        private void InitActionEventsInternal()
        {
            mInputProvider.Play.Horizontal.performed += context => IsHorizontalPerformed = true;
            mInputProvider.Play.Horizontal.canceled += context => IsHorizontalPerformed = false;

            mInputProvider.Play.Vertical.performed += context => IsVerticalPerformed = true;
            mInputProvider.Play.Vertical.canceled += context => IsVerticalPerformed = false;

            mInputProvider.Play.Run.performed += context => IsRunPerformed = true;
            mInputProvider.Play.Run.canceled += context => IsRunPerformed = false;

            mInputProvider.Play.UseTool.performed += context => IsUseToolPerformed = true;
            mInputProvider.Play.UseTool.canceled += context => IsUseToolPerformed = false;
        }
    }
}
