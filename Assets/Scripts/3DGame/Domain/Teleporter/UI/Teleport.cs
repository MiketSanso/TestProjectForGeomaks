using UnityEngine;
using Zenject;
using TestProjectForGeomaks.Business.UseCases;

public class Teleport : MonoBehaviour
{
    [Inject]
    private TouchScreen _touchScreen;

    [Inject]
    private TeleportationUseCase _teleportationUseCase;

    [SerializeField]
    private float _distanceToPlayer;

    [SerializeField]
    private int _sceneNumber;

    public void TouchTeleport()
    {
        _teleportationUseCase.Execute(_touchScreen.transform.position, transform.position, _distanceToPlayer, _sceneNumber);
    }
}
