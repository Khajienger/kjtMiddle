using Unity.Entities;

namespace kjtMiddle
{
    public class CharacterShotSystem : ComponentSystem
    {
        private EntityQuery shotQuery;

        protected override void OnCreate()
        {
            shotQuery = GetEntityQuery(
                ComponentType.ReadOnly<InputData>(),
                ComponentType.ReadOnly<ShotData>(),
                ComponentType.ReadOnly<UserInputData>());
        }

        protected override void OnUpdate()
        {
            Entities.With(shotQuery).ForEach((
                Entity entity,
                UserInputData userInputData,
                ref InputData inputData
                ) =>
            {
                if (inputData.Shot > 0f && userInputData.shotAction != null && userInputData.shotAction is IAbility ability)
                {
                    ability.Execute();
                }
            });
        }
    }
}