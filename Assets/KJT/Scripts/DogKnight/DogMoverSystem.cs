using Unity.Entities;
using UnityEngine;

namespace kjtMiddle
{
    public class DogMoverSystem : ComponentSystem
    {
        private EntityQuery query;

        protected override void OnCreate()
        {
            query = GetEntityQuery(ComponentType.ReadOnly<DogMover>());
        }

        protected override void OnUpdate()
        {
            Entities.With(query).ForEach((
                Entity entity,
                Transform transform,
                DogMover dogmover
                ) =>
            {
                transform.position += new Vector3(0.0f, dogmover.speed, 0.0f);
            });
        }
    }
}