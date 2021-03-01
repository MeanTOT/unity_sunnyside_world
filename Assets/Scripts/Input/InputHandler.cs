using UnityEngine;
using UnityEngine.InputSystem;

namespace Sunny
{
    public static class InputHandler
    {
        static private InputProvider mInputProvider = null;
        static private InputActionMap mCurrentActionMap = null;

        static public bool IsHorizontalPerformed { get; private set; }
        static public bool IsVerticalPerformed { get; private set; }
        static public bool IsRunPerformed { get; private set; }
        static public Vector2 MoveValue
        { 
            get 
            {
                return new Vector2(mInputProvider.Play.Horizontal.ReadValue<float>(), mInputProvider.Play.Vertical.ReadValue<float>());
            }
        }

        static InputHandler()
        {
            InitInputProviderInternal();
            InitInputActionMapsInternal();
            InitActionEventsInternal();
        }

        private static void InitInputProviderInternal()
        {
            if (mInputProvider == null)
                mInputProvider = new InputProvider();

            mInputProvider.Enable();            
            Application.quitting += () => mInputProvider.Disable();
        }

        private static void InitInputActionMapsInternal()
        {
            mCurrentActionMap = mInputProvider.Play;
        }

        private static void InitActionEventsInternal()
        {
            mInputProvider.Play.Horizontal.performed += context => IsHorizontalPerformed = true;
            mInputProvider.Play.Horizontal.canceled += context => IsHorizontalPerformed = false;

            mInputProvider.Play.Vertical.performed += context => IsVerticalPerformed = true;
            mInputProvider.Play.Vertical.canceled += context => IsVerticalPerformed = false;

            mInputProvider.Play.Run.performed += context => IsRunPerformed = true;
            mInputProvider.Play.Run.canceled += context => IsRunPerformed = false;
        }
    }
}
