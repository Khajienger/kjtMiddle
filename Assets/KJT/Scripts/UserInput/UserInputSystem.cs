using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace kjtMiddle
{
    public class UserInputSystem : ComponentSystem, Controls.IControlsMapActions
    {
        private Controls controls;

        private EntityQuery inputQuery;

        private float2 moveInput;
        private float shotInput;
        private float throwInput;

        public void OnMoveAction(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
        }

        public void OnShotAction(InputAction.CallbackContext context)
        {
            shotInput = context.ReadValue<float>();
        }

        public void OnThrowAction(InputAction.CallbackContext context)
        {
            throwInput = context.ReadValue<float>();
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            controls = new Controls();

            inputQuery = GetEntityQuery(ComponentType.ReadOnly<InputData>());
        }

        protected override void OnStartRunning()
        {
            controls.ControlsMap.SetCallbacks(this);
            controls.ControlsMap.Enable();
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