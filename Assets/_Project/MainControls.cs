//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/_Project/MainControls.inputactions
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

public partial class @MainControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Base"",
            ""id"": ""78609c5f-ac2e-455b-ae1d-44ccb898b9d4"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""68558e82-9dc1-44a6-a37e-32b2b04c58ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6c198ee9-f82d-4183-8843-fcc9b48e9403"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleMode"",
                    ""type"": ""Button"",
                    ""id"": ""1767265d-882e-4850-b019-431f05959334"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f249d25-f3b3-4bf5-8ff2-75f6d2928e6b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a467c9e7-dcc0-47d2-9287-e3105d317d3f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c63ddc0d-26e5-4906-b801-83a28d53a76e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Placement"",
            ""id"": ""19cca2a0-a41a-4338-bfba-19b635febfc8"",
            ""actions"": [
                {
                    ""name"": ""PlaceTower"",
                    ""type"": ""Button"",
                    ""id"": ""2330761d-3c99-40bd-b6d5-508f37c89a3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""327ee994-38d6-4cdb-b9f7-93734e62a4f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleMode"",
                    ""type"": ""Button"",
                    ""id"": ""86275e51-f579-4a3e-bae7-865307f812f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectTower1"",
                    ""type"": ""Button"",
                    ""id"": ""7123b148-cf68-4c79-8184-ca8d68379712"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectTower2"",
                    ""type"": ""Button"",
                    ""id"": ""2767e48a-e240-4b71-950d-7c68eb54f076"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38c7f95b-0dfd-42e7-b0a7-ed008ae7c5cf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceTower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1431a699-c7ac-4215-9b3d-89575b54c71e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""116da12d-5d1c-49da-8fcc-3d0b83c45f52"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd188ae7-f7d1-41b0-8a7a-e46c00310cb5"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectTower1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0916954b-2668-4772-ab3d-4c481f04abb5"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectTower2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Base
        m_Base = asset.FindActionMap("Base", throwIfNotFound: true);
        m_Base_Select = m_Base.FindAction("Select", throwIfNotFound: true);
        m_Base_Pause = m_Base.FindAction("Pause", throwIfNotFound: true);
        m_Base_ToggleMode = m_Base.FindAction("ToggleMode", throwIfNotFound: true);
        // Placement
        m_Placement = asset.FindActionMap("Placement", throwIfNotFound: true);
        m_Placement_PlaceTower = m_Placement.FindAction("PlaceTower", throwIfNotFound: true);
        m_Placement_Cancel = m_Placement.FindAction("Cancel", throwIfNotFound: true);
        m_Placement_ToggleMode = m_Placement.FindAction("ToggleMode", throwIfNotFound: true);
        m_Placement_SelectTower1 = m_Placement.FindAction("SelectTower1", throwIfNotFound: true);
        m_Placement_SelectTower2 = m_Placement.FindAction("SelectTower2", throwIfNotFound: true);
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

    // Base
    private readonly InputActionMap m_Base;
    private List<IBaseActions> m_BaseActionsCallbackInterfaces = new List<IBaseActions>();
    private readonly InputAction m_Base_Select;
    private readonly InputAction m_Base_Pause;
    private readonly InputAction m_Base_ToggleMode;
    public struct BaseActions
    {
        private @MainControls m_Wrapper;
        public BaseActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Base_Select;
        public InputAction @Pause => m_Wrapper.m_Base_Pause;
        public InputAction @ToggleMode => m_Wrapper.m_Base_ToggleMode;
        public InputActionMap Get() { return m_Wrapper.m_Base; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseActions set) { return set.Get(); }
        public void AddCallbacks(IBaseActions instance)
        {
            if (instance == null || m_Wrapper.m_BaseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BaseActionsCallbackInterfaces.Add(instance);
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @ToggleMode.started += instance.OnToggleMode;
            @ToggleMode.performed += instance.OnToggleMode;
            @ToggleMode.canceled += instance.OnToggleMode;
        }

        private void UnregisterCallbacks(IBaseActions instance)
        {
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @ToggleMode.started -= instance.OnToggleMode;
            @ToggleMode.performed -= instance.OnToggleMode;
            @ToggleMode.canceled -= instance.OnToggleMode;
        }

        public void RemoveCallbacks(IBaseActions instance)
        {
            if (m_Wrapper.m_BaseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBaseActions instance)
        {
            foreach (var item in m_Wrapper.m_BaseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BaseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BaseActions @Base => new BaseActions(this);

    // Placement
    private readonly InputActionMap m_Placement;
    private List<IPlacementActions> m_PlacementActionsCallbackInterfaces = new List<IPlacementActions>();
    private readonly InputAction m_Placement_PlaceTower;
    private readonly InputAction m_Placement_Cancel;
    private readonly InputAction m_Placement_ToggleMode;
    private readonly InputAction m_Placement_SelectTower1;
    private readonly InputAction m_Placement_SelectTower2;
    public struct PlacementActions
    {
        private @MainControls m_Wrapper;
        public PlacementActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlaceTower => m_Wrapper.m_Placement_PlaceTower;
        public InputAction @Cancel => m_Wrapper.m_Placement_Cancel;
        public InputAction @ToggleMode => m_Wrapper.m_Placement_ToggleMode;
        public InputAction @SelectTower1 => m_Wrapper.m_Placement_SelectTower1;
        public InputAction @SelectTower2 => m_Wrapper.m_Placement_SelectTower2;
        public InputActionMap Get() { return m_Wrapper.m_Placement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlacementActions set) { return set.Get(); }
        public void AddCallbacks(IPlacementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlacementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlacementActionsCallbackInterfaces.Add(instance);
            @PlaceTower.started += instance.OnPlaceTower;
            @PlaceTower.performed += instance.OnPlaceTower;
            @PlaceTower.canceled += instance.OnPlaceTower;
            @Cancel.started += instance.OnCancel;
            @Cancel.performed += instance.OnCancel;
            @Cancel.canceled += instance.OnCancel;
            @ToggleMode.started += instance.OnToggleMode;
            @ToggleMode.performed += instance.OnToggleMode;
            @ToggleMode.canceled += instance.OnToggleMode;
            @SelectTower1.started += instance.OnSelectTower1;
            @SelectTower1.performed += instance.OnSelectTower1;
            @SelectTower1.canceled += instance.OnSelectTower1;
            @SelectTower2.started += instance.OnSelectTower2;
            @SelectTower2.performed += instance.OnSelectTower2;
            @SelectTower2.canceled += instance.OnSelectTower2;
        }

        private void UnregisterCallbacks(IPlacementActions instance)
        {
            @PlaceTower.started -= instance.OnPlaceTower;
            @PlaceTower.performed -= instance.OnPlaceTower;
            @PlaceTower.canceled -= instance.OnPlaceTower;
            @Cancel.started -= instance.OnCancel;
            @Cancel.performed -= instance.OnCancel;
            @Cancel.canceled -= instance.OnCancel;
            @ToggleMode.started -= instance.OnToggleMode;
            @ToggleMode.performed -= instance.OnToggleMode;
            @ToggleMode.canceled -= instance.OnToggleMode;
            @SelectTower1.started -= instance.OnSelectTower1;
            @SelectTower1.performed -= instance.OnSelectTower1;
            @SelectTower1.canceled -= instance.OnSelectTower1;
            @SelectTower2.started -= instance.OnSelectTower2;
            @SelectTower2.performed -= instance.OnSelectTower2;
            @SelectTower2.canceled -= instance.OnSelectTower2;
        }

        public void RemoveCallbacks(IPlacementActions instance)
        {
            if (m_Wrapper.m_PlacementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlacementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlacementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlacementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlacementActions @Placement => new PlacementActions(this);
    public interface IBaseActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnToggleMode(InputAction.CallbackContext context);
    }
    public interface IPlacementActions
    {
        void OnPlaceTower(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnToggleMode(InputAction.CallbackContext context);
        void OnSelectTower1(InputAction.CallbackContext context);
        void OnSelectTower2(InputAction.CallbackContext context);
    }
}
