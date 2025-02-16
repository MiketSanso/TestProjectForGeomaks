using UnityEngine.SceneManagement;

namespace TestProjectForGeomaks.Business.UseCases
{
    public class ChangeSceneUseCase
    {
        public void Execute(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
