//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs/CurlingInputActions.inputactions
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

public partial class @CurlingInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CurlingInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CurlingInputActions"",
    ""maps"": [
        {
            ""name"": ""Thrower"",
            ""id"": ""b8ecb50b-908e-442b-9ec6-c19fc6eb789e"",
            ""actions"": [
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""39ffc37e-0ec0-4e38-86e4-00cfcadb537e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeAngle"",
                    ""type"": ""Button"",
                    ""id"": ""a88765a3-c0b8-4d8a-aed8-a98dde35ad06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeSpin"",
                    ""type"": ""Button"",
                    ""id"": ""2cfb5c00-8a21-4caf-947c-d9c65f74fca4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4b6192a-9e99-4cf6-a325-7706084185d4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""17cef719-712d-4556-b43a-c5d26da173aa"",
                    ""path"": ""1DAxis(minValue=-0.1,maxValue=0.1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeAngle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ad48cc80-39fb-443e-90d1-6ec022d8ba3d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4aba0d3f-8c31-4804-9339-98a8176eb093"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a910b380-ed01-4c4a-94d6-a5e0448ae9d7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""ChangeSpin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""efc84ecf-59e3-4f08-a306-4fdab549d35c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d2d3d586-557e-4c20-a6fa-73731452f2f2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSpin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Sweeper"",
            ""id"": ""bdeec1c2-ca62-41df-9d6a-2220bd505448"",
            ""actions"": [
                {
                    ""name"": ""SweepIn"",
                    ""type"": ""Button"",
                    ""id"": ""76f0aa94-0c59-4975-9445-ca228298ec12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SweepOut"",
                    ""type"": ""Button"",
                    ""id"": ""16312136-9dd3-42b3-8a93-42ce0c987aa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7338cb03-c888-423f-9669-fab69ec0f529"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SweepIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""127f1f0f-8938-4a46-ac80-8a6478fe28ed"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SweepOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Thrower
        m_Thrower = asset.FindActionMap("Thrower", throwIfNotFound: true);
        m_Thrower_Throw = m_Thrower.FindAction("Throw", throwIfNotFound: true);
        m_Thrower_ChangeAngle = m_Thrower.FindAction("ChangeAngle", throwIfNotFound: true);
        m_Thrower_ChangeSpin = m_Thrower.FindAction("ChangeSpin", throwIfNotFound: true);
        // Sweeper
        m_Sweeper = asset.FindActionMap("Sweeper", throwIfNotFound: true);
        m_Sweeper_SweepIn = m_Sweeper.FindAction("SweepIn", throwIfNotFound: true);
        m_Sweeper_SweepOut = m_Sweeper.FindAction("SweepOut", throwIfNotFound: true);
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

    // Thrower
    private readonly InputActionMap m_Thrower;
    private IThrowerActions m_ThrowerActionsCallbackInterface;
    private readonly InputAction m_Thrower_Throw;
    private readonly InputAction m_Thrower_ChangeAngle;
    private readonly InputAction m_Thrower_ChangeSpin;
    public struct ThrowerActions
    {
        private @CurlingInputActions m_Wrapper;
        public ThrowerActions(@CurlingInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throw => m_Wrapper.m_Thrower_Throw;
        public InputAction @ChangeAngle => m_Wrapper.m_Thrower_ChangeAngle;
        public InputAction @ChangeSpin => m_Wrapper.m_Thrower_ChangeSpin;
        public InputActionMap Get() { return m_Wrapper.m_Thrower; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThrowerActions set) { return set.Get(); }
        public void SetCallbacks(IThrowerActions instance)
        {
            if (m_Wrapper.m_ThrowerActionsCallbackInterface != null)
            {
                @Throw.started -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnThrow;
                @ChangeAngle.started -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeAngle;
                @ChangeAngle.performed -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeAngle;
                @ChangeAngle.canceled -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeAngle;
                @ChangeSpin.started -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeSpin;
                @ChangeSpin.performed -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeSpin;
                @ChangeSpin.canceled -= m_Wrapper.m_ThrowerActionsCallbackInterface.OnChangeSpin;
            }
            m_Wrapper.m_ThrowerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @ChangeAngle.started += instance.OnChangeAngle;
                @ChangeAngle.performed += instance.OnChangeAngle;
                @ChangeAngle.canceled += instance.OnChangeAngle;
                @ChangeSpin.started += instance.OnChangeSpin;
                @ChangeSpin.performed += instance.OnChangeSpin;
                @ChangeSpin.canceled += instance.OnChangeSpin;
            }
        }
    }
    public ThrowerActions @Thrower => new ThrowerActions(this);

    // Sweeper
    private readonly InputActionMap m_Sweeper;
    private ISweeperActions m_SweeperActionsCallbackInterface;
    private readonly InputAction m_Sweeper_SweepIn;
    private readonly InputAction m_Sweeper_SweepOut;
    public struct SweeperActions
    {
        private @CurlingInputActions m_Wrapper;
        public SweeperActions(@CurlingInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SweepIn => m_Wrapper.m_Sweeper_SweepIn;
        public InputAction @SweepOut => m_Wrapper.m_Sweeper_SweepOut;
        public InputActionMap Get() { return m_Wrapper.m_Sweeper; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SweeperActions set) { return set.Get(); }
        public void SetCallbacks(ISweeperActions instance)
        {
            if (m_Wrapper.m_SweeperActionsCallbackInterface != null)
            {
                @SweepIn.started -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepIn;
                @SweepIn.performed -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepIn;
                @SweepIn.canceled -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepIn;
                @SweepOut.started -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepOut;
                @SweepOut.performed -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepOut;
                @SweepOut.canceled -= m_Wrapper.m_SweeperActionsCallbackInterface.OnSweepOut;
            }
            m_Wrapper.m_SweeperActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SweepIn.started += instance.OnSweepIn;
                @SweepIn.performed += instance.OnSweepIn;
                @SweepIn.canceled += instance.OnSweepIn;
                @SweepOut.started += instance.OnSweepOut;
                @SweepOut.performed += instance.OnSweepOut;
                @SweepOut.canceled += instance.OnSweepOut;
            }
        }
    }
    public SweeperActions @Sweeper => new SweeperActions(this);
    public interface IThrowerActions
    {
        void OnThrow(InputAction.CallbackContext context);
        void OnChangeAngle(InputAction.CallbackContext context);
        void OnChangeSpin(InputAction.CallbackContext context);
    }
    public interface ISweeperActions
    {
        void OnSweepIn(InputAction.CallbackContext context);
        void OnSweepOut(InputAction.CallbackContext context);
    }
}