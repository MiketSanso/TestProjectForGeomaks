using UnityEngine;
using Zenject;

public class TouchScreenInstaller : MonoInstaller
{
    [SerializeField]
    private TouchScreen _touchScreen;

    public override void InstallBindings()
    {
        Container.Bind<TouchScreen>().FromInstance(_touchScreen).AsSingle();
    }
}
