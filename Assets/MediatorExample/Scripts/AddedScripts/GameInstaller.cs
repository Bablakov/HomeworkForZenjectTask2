using UnityEngine;
using Zenject;

namespace MediatorExample.Scripts.AddedScripts
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameplayMediator _gameplayMediator;
        [SerializeField] private DefeatPanel _defeatPanel;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Level>().AsSingle();
            Container.BindInterfacesAndSelfTo<DefeatPanel>().FromInstance(_defeatPanel);
            Container.BindInterfacesAndSelfTo<GameplayMediator>().FromInstance(_gameplayMediator);
        }
    }
}