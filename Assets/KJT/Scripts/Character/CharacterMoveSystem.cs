using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace kjtMiddle
{
    public class CharacterMoveSystem : ComponentSystem
    {
        private EntityQuery moveQuery;

        protected override void OnCreate()
        {
            moveQuery = GetEntityQuery(
                ComponentType.ReadOnly<InputData>(),
                ComponentType.ReadOnly<MoveData>(),
                ComponentType.ReadOnly<Transform>());
        }

        protected override void OnUpdate()
        {
            Entities.With(moveQuery).ForEach((
                Entity entity,
                Transform transform,
                ref InputData inputData,
                ref MoveData moveData
                ) =>
            {
                float3 _pos = transform.position;
                _pos += new float3(
                    inputData.Move.x * moveData.Speed,
                    0,
                    inputData.Move.y * moveData.Speed);
                transform.position = _pos;
            });
        }
    }
}