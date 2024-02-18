using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace kjtMiddle
{
    public class UserInputData : MonoBehaviour, IConvertGameObjectToEntity
    {
        [HideInInspector]
        public float2 move;

        [SerializeField]
        [Range(0.01f, 100)]
        public float speed;

        [SerializeField]
        public MonoBehaviour shotAction;

        [SerializeField]
        public MonoBehaviour throwAction;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new InputData());

            dstManager.AddComponentData(entity, new MoveData
            {
                Speed = this.speed
            });

            if (shotAction != null && shotAction is IAbility)
            {
                dstManager.AddComponentData(entity, new ShotData());
            }

            if (throwAction != null && throwAction is IAbility)
            {
                dstManager.AddComponentData(entity, new ThrowData());
            }
        }
    }

    public struct InputData : IComponentData
    {
        public float2 Move;
        public float Shot;
        public float Throw;
    }

    public struct MoveData : IComponentData
    {
        public float Speed;
    }

    public struct ShotData : IComponentData
    {

    }

    public struct ThrowData : IComponentData
    {

    }
}