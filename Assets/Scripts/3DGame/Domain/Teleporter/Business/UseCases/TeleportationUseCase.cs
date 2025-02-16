using UnityEngine;
using Zenject;

namespace TestProjectForGeomaks.Business.UseCases
{
    public class TeleportationUseCase
    {
        [Inject]
        private ChangeSceneUseCase _changeSceneUseCase;

        public void Execute(Vector3 firstPosition, Vector3 secondPosition, float maxDistance, int numberScene)
        {
            if (Vector3.Distance(firstPosition, secondPosition) <= maxDistance)
            {
                _changeSceneUseCase.Execute(numberScene);
            }
        }
    }
}