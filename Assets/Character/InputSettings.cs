// GENERATED AUTOMATICALLY FROM 'Assets/Character/InputSettings.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSettings : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSettings()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSettings"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""da63bf3a-f27c-4796-9879-fca5a10cad00"",
            ""actions"": [
                {
                    ""name"": ""LeftMovement"",
                    ""type"": ""Value"",
                    ""id"": ""cb3893b7-ff0a-4f28-a846-27ec7b8f5b9e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""2672034c-1dbc-4336-990e-3c67595395ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMovement"",
                    ""type"": ""Button"",
                    ""id"": ""c2856e98-3352-4268-a9e6-55fca7e95d8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""7fd088be-9e4d-45dc-b935-2f2373556f1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fd507ddd-eee4-4a13-8030-d844912b1f92"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea1551bb-d918-418f-8e13-eedf92ca6b50"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0985f5fa-6759-4f05-8ba3-ad8b7b8efb7e"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""94fbbb1e-a1fb-46c8-b74e-b48b43af212d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""82ea68e8-c0b6-4c96-8c4f-2abb5c78d9a5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4c3e96f0-843b-48ee-88fe-da249b3de9ca"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""084bb384-347b-4748-bc6b-c4d504d0996b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2e501b92-7725-4614-827c-9d15373dcd81"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dcc1e7d1-d5f1-4887-8466-7b2d811bde4c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0aa16176-a39b-492c-89b7-c2cb510eae45"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d1e14af6-cebe-4417-a963-c4608e790f64"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aac6dc14-a936-4bf5-904c-ae9b86d35953"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8ea99060-ff0c-4c15-a903-2a56c417f9ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c0072d62-837e-4391-98f6-fb544f7cda40"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""36cd024a-843e-43cd-ac1b-0cd6426bffec"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dcba3b81-8283-441d-8d86-43148ffe0352"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""17ee5c06-714a-41d4-8509-e2465a4378e8"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0cfdbd76-cf60-4d7e-bd1e-4a0bba84d37e"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3be04923-6138-46aa-b5ae-805127490add"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""db3d3b0c-0a44-40fa-984a-f239f146f222"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50695c04-ef7b-40ae-814d-7812f1ae593b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""003c45cd-6a35-45f5-9934-7d2dd9feba86"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fc2a0d95-627c-4bce-9304-28e41f13a469"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ac65cb0e-4ea1-40c0-ac2a-c78cf0af994b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a2ce47b-c38d-4235-9353-567208e36e16"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd7bb7e3-d164-4a02-9e97-3825b6aba729"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joypad"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Joypad"",
            ""bindingGroup"": ""Joypad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_LeftMovement = m_Character.FindAction("LeftMovement", throwIfNotFound: true);
        m_Character_LeftStick = m_Character.FindAction("LeftStick", throwIfNotFound: true);
        m_Character_RightMovement = m_Character.FindAction("RightMovement", throwIfNotFound: true);
        m_Character_RightStick = m_Character.FindAction("RightStick", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_LeftMovement;
    private readonly InputAction m_Character_LeftStick;
    private readonly InputAction m_Character_RightMovement;
    private readonly InputAction m_Character_RightStick;
    public struct CharacterActions
    {
        private @InputSettings m_Wrapper;
        public CharacterActions(@InputSettings wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftMovement => m_Wrapper.m_Character_LeftMovement;
        public InputAction @LeftStick => m_Wrapper.m_Character_LeftStick;
        public InputAction @RightMovement => m_Wrapper.m_Character_RightMovement;
        public InputAction @RightStick => m_Wrapper.m_Character_RightStick;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @LeftMovement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftMovement;
                @LeftStick.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeftStick;
                @RightMovement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightMovement;
                @RightMovement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightMovement;
                @RightMovement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightMovement;
                @RightStick.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRightStick;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftMovement.started += instance.OnLeftMovement;
                @LeftMovement.performed += instance.OnLeftMovement;
                @LeftMovement.canceled += instance.OnLeftMovement;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightMovement.started += instance.OnRightMovement;
                @RightMovement.performed += instance.OnRightMovement;
                @RightMovement.canceled += instance.OnRightMovement;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    private int m_JoypadSchemeIndex = -1;
    public InputControlScheme JoypadScheme
    {
        get
        {
            if (m_JoypadSchemeIndex == -1) m_JoypadSchemeIndex = asset.FindControlSchemeIndex("Joypad");
            return asset.controlSchemes[m_JoypadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface ICharacterActions
    {
        void OnLeftMovement(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightMovement(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
    }
}
