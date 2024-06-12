//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInputAction.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""272e1fbd-1850-439a-82a3-f7d6f53893eb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""fd01dbcf-0216-425f-ba9c-a0123095f5e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""87824e49-e069-423f-ab84-021428373028"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe118fe2-378a-4ce8-aad7-4459f5e788f6"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""67c26246-5bfa-4109-9d07-85818048fa93"",
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
                    ""id"": ""89ed509b-c8d3-4e96-820b-f8ba37d125a6"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""03b09124-55ad-4278-a8fa-d107d1c5c1d5"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""518822b7-cff3-4c29-acae-7810adb4e7d9"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""18ade2d4-8412-4aa2-951d-ff6acc853f93"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado WSAD"",
                    ""id"": ""53eb9c54-c044-4c39-85ce-4089fed5aff6"",
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
                    ""id"": ""488ed24e-bf59-4daf-8370-e447b72e8920"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a042ed6d-0335-4bd8-822f-ce3f04d7ff2c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1f12e37b-4623-489d-93bb-a48a59dde5d4"",
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
                    ""id"": ""b75e56de-23e6-4fca-a24f-ae4217ad5741"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Astrounaut"",
            ""id"": ""eafbe7df-92c2-4d7f-9562-01f4450576a5"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""cdb5b240-3d48-400d-848f-79abc2350199"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movimento"",
                    ""type"": ""Value"",
                    ""id"": ""e81278b6-a461-4ec0-8b21-245ede6b6f5e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pular"",
                    ""type"": ""Button"",
                    ""id"": ""0e08f58f-636f-45b4-bd91-827fabb3ad49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58ae6744-c3bb-4703-b31d-ff281acc3e79"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0d0b086c-781f-40ed-ba76-f959197ac3b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3dde3227-bc7e-4ac3-ac98-673e2b330732"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8c66f40b-79ab-426a-bc47-0b85741385fb"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a0c1359a-5022-4510-bca5-d52648696bae"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7f04b85-17e8-4d56-9728-4c13921f08e6"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado WSAD"",
                    ""id"": ""161eb41d-fb4b-4d59-9394-c50040f67313"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""04122cab-07f1-43c0-a8c9-d67f221449a4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2f38d585-9762-4a03-94f1-00285106dd97"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f4af091e-580f-424c-90fb-e2a5dccae250"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""423a77bc-dffd-4bd5-b26b-f9b0fbc48e5f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""587d1328-fee6-4a08-ac2e-b8a9c40a1bf7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""61e80b5a-72b6-47e3-affd-ac12ac72b517"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a0f45328-a7f0-4636-8d74-338f891633c6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b643659b-98fd-4704-9c86-5be99c3b9ccb"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2d68a523-c566-4b65-ba34-e8accfde2ddb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""38af64ab-e06e-4468-a226-80961cfe8d1a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pular"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66e8d22f-92d1-4397-b5b4-489d33514064"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pular"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_Move = m_Rocket.FindAction("Move", throwIfNotFound: true);
        m_Rocket_Look = m_Rocket.FindAction("Look", throwIfNotFound: true);
        // Astrounaut
        m_Astrounaut = asset.FindActionMap("Astrounaut", throwIfNotFound: true);
        m_Astrounaut_Camera = m_Astrounaut.FindAction("Camera", throwIfNotFound: true);
        m_Astrounaut_Movimento = m_Astrounaut.FindAction("Movimento", throwIfNotFound: true);
        m_Astrounaut_Pular = m_Astrounaut.FindAction("Pular", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
    private readonly InputAction m_Rocket_Move;
    private readonly InputAction m_Rocket_Look;
    public struct RocketActions
    {
        private @PlayerInputAction m_Wrapper;
        public RocketActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Rocket_Move;
        public InputAction @Look => m_Wrapper.m_Rocket_Look;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void AddCallbacks(IRocketActions instance)
        {
            if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(IRocketActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRocketActions instance)
        {
            foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RocketActions @Rocket => new RocketActions(this);

    // Astrounaut
    private readonly InputActionMap m_Astrounaut;
    private List<IAstrounautActions> m_AstrounautActionsCallbackInterfaces = new List<IAstrounautActions>();
    private readonly InputAction m_Astrounaut_Camera;
    private readonly InputAction m_Astrounaut_Movimento;
    private readonly InputAction m_Astrounaut_Pular;
    public struct AstrounautActions
    {
        private @PlayerInputAction m_Wrapper;
        public AstrounautActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Astrounaut_Camera;
        public InputAction @Movimento => m_Wrapper.m_Astrounaut_Movimento;
        public InputAction @Pular => m_Wrapper.m_Astrounaut_Pular;
        public InputActionMap Get() { return m_Wrapper.m_Astrounaut; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AstrounautActions set) { return set.Get(); }
        public void AddCallbacks(IAstrounautActions instance)
        {
            if (instance == null || m_Wrapper.m_AstrounautActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AstrounautActionsCallbackInterfaces.Add(instance);
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Movimento.started += instance.OnMovimento;
            @Movimento.performed += instance.OnMovimento;
            @Movimento.canceled += instance.OnMovimento;
            @Pular.started += instance.OnPular;
            @Pular.performed += instance.OnPular;
            @Pular.canceled += instance.OnPular;
        }

        private void UnregisterCallbacks(IAstrounautActions instance)
        {
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Movimento.started -= instance.OnMovimento;
            @Movimento.performed -= instance.OnMovimento;
            @Movimento.canceled -= instance.OnMovimento;
            @Pular.started -= instance.OnPular;
            @Pular.performed -= instance.OnPular;
            @Pular.canceled -= instance.OnPular;
        }

        public void RemoveCallbacks(IAstrounautActions instance)
        {
            if (m_Wrapper.m_AstrounautActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAstrounautActions instance)
        {
            foreach (var item in m_Wrapper.m_AstrounautActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AstrounautActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AstrounautActions @Astrounaut => new AstrounautActions(this);
    public interface IRocketActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IAstrounautActions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnMovimento(InputAction.CallbackContext context);
        void OnPular(InputAction.CallbackContext context);
    }
}
