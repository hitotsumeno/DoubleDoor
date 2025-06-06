//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/ActionMap/FirstPlayerActionMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @FirstPlayerActionMap: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FirstPlayerActionMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FirstPlayerActionMap"",
    ""maps"": [
        {
            ""name"": ""Player1Controls"",
            ""id"": ""5144a018-6e5f-459c-bbd3-f70b3f625799"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ba3ce321-2b88-4faf-b755-5de98c4e32cd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""eeb4f8a9-27fa-4abd-995b-0f08433654a3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c4d2069b-eb40-418e-a6bf-783fb8a8f5ab"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""41a51ca5-5a87-4927-a911-c7e044139946"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""553998ea-580e-49c4-829a-5766eec4343a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf1fbe92-f950-4798-a505-f9e72876b8de"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15302116-9ca1-43a3-b274-d783c200057e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f818926b-0415-458e-b0ad-b8281afb4b85"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1UI"",
            ""id"": ""12ce3c20-56dd-4eb3-9e1e-caf25000a6e4"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""ca0f05bb-a3fd-45e1-8cd0-c83786fe24bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""c61fbc13-37fd-4e7d-aa14-e44e7899e455"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a51ad92-6d93-4a8e-9118-e89db0998adc"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d99f7c36-a49c-4340-8cd4-8d3d48ad8461"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Controls
        m_Player1Controls = asset.FindActionMap("Player1Controls", throwIfNotFound: true);
        m_Player1Controls_Move = m_Player1Controls.FindAction("Move", throwIfNotFound: true);
        m_Player1Controls_Jump = m_Player1Controls.FindAction("Jump", throwIfNotFound: true);
        // Player1UI
        m_Player1UI = asset.FindActionMap("Player1UI", throwIfNotFound: true);
        m_Player1UI_Resume = m_Player1UI.FindAction("Resume", throwIfNotFound: true);
        m_Player1UI_Pause = m_Player1UI.FindAction("Pause", throwIfNotFound: true);
    }

    ~@FirstPlayerActionMap()
    {
        UnityEngine.Debug.Assert(!m_Player1Controls.enabled, "This will cause a leak and performance issues, FirstPlayerActionMap.Player1Controls.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Player1UI.enabled, "This will cause a leak and performance issues, FirstPlayerActionMap.Player1UI.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player1Controls
    private readonly InputActionMap m_Player1Controls;
    private List<IPlayer1ControlsActions> m_Player1ControlsActionsCallbackInterfaces = new List<IPlayer1ControlsActions>();
    private readonly InputAction m_Player1Controls_Move;
    private readonly InputAction m_Player1Controls_Jump;
    public struct Player1ControlsActions
    {
        private @FirstPlayerActionMap m_Wrapper;
        public Player1ControlsActions(@FirstPlayerActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1Controls_Move;
        public InputAction @Jump => m_Wrapper.m_Player1Controls_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player1Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1ControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1ControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_Player1ControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1ControlsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayer1ControlsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayer1ControlsActions instance)
        {
            if (m_Wrapper.m_Player1ControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1ControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_Player1ControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1ControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1ControlsActions @Player1Controls => new Player1ControlsActions(this);

    // Player1UI
    private readonly InputActionMap m_Player1UI;
    private List<IPlayer1UIActions> m_Player1UIActionsCallbackInterfaces = new List<IPlayer1UIActions>();
    private readonly InputAction m_Player1UI_Resume;
    private readonly InputAction m_Player1UI_Pause;
    public struct Player1UIActions
    {
        private @FirstPlayerActionMap m_Wrapper;
        public Player1UIActions(@FirstPlayerActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Resume => m_Wrapper.m_Player1UI_Resume;
        public InputAction @Pause => m_Wrapper.m_Player1UI_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player1UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1UIActions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1UIActions instance)
        {
            if (instance == null || m_Wrapper.m_Player1UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1UIActionsCallbackInterfaces.Add(instance);
            @Resume.started += instance.OnResume;
            @Resume.performed += instance.OnResume;
            @Resume.canceled += instance.OnResume;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPlayer1UIActions instance)
        {
            @Resume.started -= instance.OnResume;
            @Resume.performed -= instance.OnResume;
            @Resume.canceled -= instance.OnResume;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPlayer1UIActions instance)
        {
            if (m_Wrapper.m_Player1UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1UIActions instance)
        {
            foreach (var item in m_Wrapper.m_Player1UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1UIActions @Player1UI => new Player1UIActions(this);
    public interface IPlayer1ControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayer1UIActions
    {
        void OnResume(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
