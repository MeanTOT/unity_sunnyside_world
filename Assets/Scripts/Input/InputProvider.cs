// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputProvider.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputProvider : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputProvider()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputProvider"",
    ""maps"": [
        {
            ""name"": ""Play"",
            ""id"": ""9310c7e8-965f-479f-a594-e1ad18b94d62"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""d13a9218-1427-4b18-b4bd-9389c084e709"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""1667b579-7671-4e8d-8811-d29c5bc79028"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""b00393e9-add0-4118-904d-19810be6ea2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""563169fe-ad0d-4d09-9e94-1d6cdcd77f42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""403d9c94-ccfa-4ab8-8225-190bf8b20829"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""9f30b959-46df-49b9-9559-e1d6eca1aa88"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c2b50c6c-ffda-4516-b3c8-7232c5e4be05"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2533992d-8b77-4679-b3b2-f0e737facc37"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""24599fa3-bc97-43ca-9e2b-45118b5fd84f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""74792238-c67c-47dc-b2c2-0910e858ef73"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""31906809-c499-4189-b056-d1a4592e9f4f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b581f418-e583-4974-87ce-3d298ba6afea"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c853c26a-010a-48f8-ba48-211d5d6df76f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fdfebdb-819a-45c8-ab3b-8cc7f507471c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Play
        m_Play = asset.FindActionMap("Play", throwIfNotFound: true);
        m_Play_Horizontal = m_Play.FindAction("Horizontal", throwIfNotFound: true);
        m_Play_Vertical = m_Play.FindAction("Vertical", throwIfNotFound: true);
        m_Play_Run = m_Play.FindAction("Run", throwIfNotFound: true);
        m_Play_Interaction = m_Play.FindAction("Interaction", throwIfNotFound: true);
        m_Play_MousePosition = m_Play.FindAction("MousePosition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Play
    private readonly InputActionMap m_Play;
    private IPlayActions m_PlayActionsCallbackInterface;
    private readonly InputAction m_Play_Horizontal;
    private readonly InputAction m_Play_Vertical;
    private readonly InputAction m_Play_Run;
    private readonly InputAction m_Play_Interaction;
    private readonly InputAction m_Play_MousePosition;
    public struct PlayActions
    {
        private @InputProvider m_Wrapper;
        public PlayActions(@InputProvider wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Play_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Play_Vertical;
        public InputAction @Run => m_Wrapper.m_Play_Run;
        public InputAction @Interaction => m_Wrapper.m_Play_Interaction;
        public InputAction @MousePosition => m_Wrapper.m_Play_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayActions instance)
        {
            if (m_Wrapper.m_PlayActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnVertical;
                @Run.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnRun;
                @Interaction.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnInteraction;
                @MousePosition.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_PlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public PlayActions @Play => new PlayActions(this);
    public interface IPlayActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
