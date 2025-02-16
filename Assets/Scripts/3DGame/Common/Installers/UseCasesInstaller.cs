using TestProjectForGeomaks.Business.UseCases;
using Zenject;

public class UseCasesInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ChangeSceneUseCase>().FromNew().AsSingle();
        Container.Bind<TeleportationUseCase>().FromNew().AsSingle();
    }
}