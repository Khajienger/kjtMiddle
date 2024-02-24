using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace kjtMiddle
{
    public class UserInputSystem : ComponentSystem
    {
        private Controls controls;

        private EntityQuery inputQuery;

        private InputAction moveAction;
        private InputAction shotAction;
        private InputAction throwAction;

        private float2 moveInput;
        private float shotInput;
        private float throwInput;

        protected override void OnCreate()
        {
            base.OnCreate();

            controls = new Controls();

            inputQuery = GetEntityQuery(ComponentType.ReadOnly<InputData>());
        }

        protected override void OnStartRunning()
        {
            #region MoveInput...
            
            moveAction = controls.

            //moveAction = new InputAction(name: "move", binding: GlobalStringKeys.gamepadJoystick);

            //moveAction.AddCompositeBinding(GlobalStringKeys.Dpad)
            //    .With(name: "Up", binding: GlobalStringKeys.keyW)
            //    .With(name: "Down", binding: GlobalStringKeys.keyS)
            //    .With(name: "Left", binding: GlobalStringKeys.keyA)
            //    .With(name: "Right", binding: GlobalStringKeys.keyD);

            //moveAction.started += context => { moveInput = context.ReadValue<Vector2>(); };
            //moveAction.performed += context => { moveInput = context.ReadValue<Vector2>(); };
            //moveAction.canceled += context => { moveInput = context.ReadValue<Vector2>(); };

            //moveAction.Enable();

            #endregion

            #region ShotInput...

            //shotAction = new InputAction(name: "shot", binding: GlobalStringKeys.keyLCtrl);

            //shotAction.started += context => { shotInput = 0; };
            //shotAction.performed += context => { shotInput = context.ReadValue<float>(); };
            //shotAction.canceled += context => { shotInput = context.ReadValue<float>(); };

            //shotAction.Enable();

            #endregion

            #region ThrowInput...

            //throwAction = new InputAction(name: "throw", binding: GlobalStringKeys.keySpace);

            //throwAction.started += context => { throwInput = 0; };
            //throwAction.performed += context => { throwInput = context.ReadValue<float>(); };
            //throwAction.canceled += context => { throwInput = context.ReadValue<float>(); };

            //throwAction.Enable();

            #endregion
        }

        protected override void OnStopRunning()
        {
            moveAction.Disable();
            shotAction.Disable();
            throwAction.Disable();
        }

        protected override void OnUpdate()
        {
            Entities.With(inputQuery).ForEach((
                Entity entity,
                ref InputData inputdata
                ) =>
            {
                inputdata.Move = moveInput;
                inputdata.Shot = shotInput;
                inputdata.Throw = throwInput;
            });
        }
    }
}