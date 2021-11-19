// GENERATED AUTOMATICALLY FROM 'Assets/Animation/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""TheaMain"",
            ""id"": ""32632bbd-6bf3-4fc5-b40c-cdcd2cd45be0"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74c55c99-f362-4374-9aa9-7c5c59e14e98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cd707127-60ac-44e8-b3df-f9dfae904f23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""398c364e-4448-4817-8c0d-d0aa0015070c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""03e5957a-b50c-43f5-b220-58e933af998e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""594a7f13-85cf-480c-bc88-83403e758d23"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c0e98f61-8d88-4542-b2af-83b259e7220d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ddba206-08c0-4f92-8af8-673107bc2484"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ebab0d8d-cd72-4b5c-a9b8-6ee434920981"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed834887-f2cb-4af7-9ac9-04b9b8d9f77e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""11d5c6fc-9d66-42f1-81cd-93c45955639c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a6afd91-505f-42ca-9084-497d19839e91"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb80f32f-baa9-49eb-91b9-c0c922af1ff9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""776909f5-8c7f-46a8-bf37-422ccb06093d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b51322d8-5a1b-4b45-b78a-7b7e3d83d4bb"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TheaMain
        m_TheaMain = asset.FindActionMap("TheaMain", throwIfNotFound: true);
        m_TheaMain_Run = m_TheaMain.FindAction("Run", throwIfNotFound: true);
        m_TheaMain_Jump = m_TheaMain.FindAction("Jump", throwIfNotFound: true);
        m_TheaMain_Camera = m_TheaMain.FindAction("Camera", throwIfNotFound: true);
        m_TheaMain_Shot = m_TheaMain.FindAction("Shot", throwIfNotFound: true);
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

    // TheaMain
    private readonly InputActionMap m_TheaMain;
    private ITheaMainActions m_TheaMainActionsCallbackInterface;
    private readonly InputAction m_TheaMain_Run;
    private readonly InputAction m_TheaMain_Jump;
    private readonly InputAction m_TheaMain_Camera;
    private readonly InputAction m_TheaMain_Shot;
    public struct TheaMainActions
    {
        private @PlayerActions m_Wrapper;
        public TheaMainActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_TheaMain_Run;
        public InputAction @Jump => m_Wrapper.m_TheaMain_Jump;
        public InputAction @Camera => m_Wrapper.m_TheaMain_Camera;
        public InputAction @Shot => m_Wrapper.m_TheaMain_Shot;
        public InputActionMap Get() { return m_Wrapper.m_TheaMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TheaMainActions set) { return set.Get(); }
        public void SetCallbacks(ITheaMainActions instance)
        {
            if (m_Wrapper.m_TheaMainActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Shot.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
            }
            m_Wrapper.m_TheaMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
            }
        }
    }
    public TheaMainActions @TheaMain => new TheaMainActions(this);
    public interface ITheaMainActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
    }
}
