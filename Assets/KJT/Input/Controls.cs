//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/KJT/Input/Controls.inputactions
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

namespace kjtMiddle
{
    public partial class @Controls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""ControlsMap"",
            ""id"": ""360b3c08-e2b8-49a3-8a73-f83debf94068"",
            ""actions"": [
                {
                    ""name"": ""MoveAction"",
                    ""type"": ""Value"",
                    ""id"": ""f268ab6a-4a29-4ac5-bb91-aad86ad01a8d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ShotAction"",
                    ""type"": ""Button"",
                    ""id"": ""ba1186de-b5d7-4025-8a22-4d8529f0f4df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowAction"",
                    ""type"": ""Button"",
                    ""id"": ""2dd721b1-d1b8-415b-b308-bb63e4854882"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""82915f11-425c-426e-8bd6-b9c046d26809"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""52d7713b-f491-40d1-8631-4f87df3780e4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d7883ed7-e10d-4404-9951-a92f77cf12bd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1388a62e-3845-4b2d-b3d4-a1d9277b7940"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b9f16352-2f25-4ee9-9210-2cbeb8e7bf34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aad1d9cb-8f45-44f4-a8f9-1d6e116b2417"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""30627e86-a2e6-4849-a0a0-4deac80a9e4a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""976027b9-7576-4f54-8ccc-3c822ab30757"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""587099e6-549a-474d-a27a-d1072bce3fec"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9583152d-4e67-4281-ab6a-f9067f2a667e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""362085ed-b9f0-4404-b98f-bba7877e343f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2001568-d755-41a1-b062-c5e2b602d785"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShotAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0354c11-7ca2-419f-a032-cb73d6e5a8e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // ControlsMap
            m_ControlsMap = asset.FindActionMap("ControlsMap", throwIfNotFound: true);
            m_ControlsMap_MoveAction = m_ControlsMap.FindAction("MoveAction", throwIfNotFound: true);
            m_ControlsMap_ShotAction = m_ControlsMap.FindAction("ShotAction", throwIfNotFound: true);
            m_ControlsMap_ThrowAction = m_ControlsMap.FindAction("ThrowAction", throwIfNotFound: true);
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

        // ControlsMap
        private readonly InputActionMap m_ControlsMap;
        private IControlsMapActions m_ControlsMapActionsCallbackInterface;
        private readonly InputAction m_ControlsMap_MoveAction;
        private readonly InputAction m_ControlsMap_ShotAction;
        private readonly InputAction m_ControlsMap_ThrowAction;
        public struct ControlsMapActions
        {
            private @Controls m_Wrapper;
            public ControlsMapActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveAction => m_Wrapper.m_ControlsMap_MoveAction;
            public InputAction @ShotAction => m_Wrapper.m_ControlsMap_ShotAction;
            public InputAction @ThrowAction => m_Wrapper.m_ControlsMap_ThrowAction;
            public InputActionMap Get() { return m_Wrapper.m_ControlsMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ControlsMapActions set) { return set.Get(); }
            public void SetCallbacks(IControlsMapActions instance)
            {
                if (m_Wrapper.m_ControlsMapActionsCallbackInterface != null)
                {
                    @MoveAction.started -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnMoveAction;
                    @MoveAction.performed -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnMoveAction;
                    @MoveAction.canceled -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnMoveAction;
                    @ShotAction.started -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnShotAction;
                    @ShotAction.performed -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnShotAction;
                    @ShotAction.canceled -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnShotAction;
                    @ThrowAction.started -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnThrowAction;
                    @ThrowAction.performed -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnThrowAction;
                    @ThrowAction.canceled -= m_Wrapper.m_ControlsMapActionsCallbackInterface.OnThrowAction;
                }
                m_Wrapper.m_ControlsMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveAction.started += instance.OnMoveAction;
                    @MoveAction.performed += instance.OnMoveAction;
                    @MoveAction.canceled += instance.OnMoveAction;
                    @ShotAction.started += instance.OnShotAction;
                    @ShotAction.performed += instance.OnShotAction;
                    @ShotAction.canceled += instance.OnShotAction;
                    @ThrowAction.started += instance.OnThrowAction;
                    @ThrowAction.performed += instance.OnThrowAction;
                    @ThrowAction.canceled += instance.OnThrowAction;
                }
            }
        }
        public ControlsMapActions @ControlsMap => new ControlsMapActions(this);
        public interface IControlsMapActions
        {
            void OnMoveAction(InputAction.CallbackContext context);
            void OnShotAction(InputAction.CallbackContext context);
            void OnThrowAction(InputAction.CallbackContext context);
        }
    }
}
