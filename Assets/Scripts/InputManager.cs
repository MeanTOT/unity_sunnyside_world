using UnityEngine;
using UnityEngine.InputSystem;

namespace Sunny
{
    public static class InputManager
    {
        static private InputProvider mInputProvider = null;

        static public bool IsHorizontalPerformed { get; private set; }
        static public bool IsVerticalPerformed { get; private set; }
        static public Vector2 MoveDirection 
        { 
            get 
            {
                return new Vector2(mInputProvider.Play.Horizontal.ReadValue<float>(), mInputProvider.Play.Vertical.ReadValue<float>());
            }
            set
            {
            }
        }

        static InputManager()
        {
            if (mInputProvider == null)
                mInputProvider = new InputProvider();

            mInputProvider.Play.Horizontal.performed += context => IsHorizontalPerformed = true;
            mInputProvider.Play.Horizontal.canceled += context => IsHorizontalPerformed = false;

            mInputProvider.Play.Vertical.performed += context => IsVerticalPerformed = true;
            mInputProvider.Play.Vertical.canceled += context => IsVerticalPerformed = false;

            mInputProvider.Enable();
            Application.quitting += () => mInputProvider.Disable();

            //mInputProvider.Play.Disable();
        }
    }
}
