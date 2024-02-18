using Unity.Entities;

namespace kjtMiddle
{
    public class CharacterThrowSystem : ComponentSystem
    {
        private EntityQuery throwQuery;

        protected override void OnCreate()
        {
            throwQuery = GetEntityQuery(
                ComponentType.ReadOnly<InputData>(),
                ComponentType.ReadOnly<ThrowData>(),
                ComponentType.ReadOnly<UserInputData>());
        }

        protected override void OnUpdate()
        {
            Entities.With(throwQuery).ForEach((
                Entity entity,
                UserInputData userInputData,
                ref InputData inputData
                ) =>
            {
                if (inputData.Throw > 0f && userInputData.throwAction != null && userInputData.throwAction is IAbility ability)
                {
                    ability.Execute();
                }
            });
        }
    }
}