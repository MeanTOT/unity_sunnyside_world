using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sunny
{
    public static class Locator
    {
        public static GameEvent GameEvent { get; private set; }
        public static InputHandler Input { get; private set; }
        public static Picking Picking { get; private set; }
        public static InteractionHandler InteractionHandler { get; private set; }

        static Locator()
        {
            GameEvent = new GameEvent();
            Input = new InputHandler();
            Picking = new Picking();
            InteractionHandler = new InteractionHandler();
        }
    }
}
