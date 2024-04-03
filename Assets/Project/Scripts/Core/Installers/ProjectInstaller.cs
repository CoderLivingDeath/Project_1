using Project.Scripts.Core.Infrastructure;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Project.Scripts.Core.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallSceneLoader();
            InstallInputSystem();
            Debug.Log($"{nameof(ProjectInstaller): has installed.}");
        }

        private void InstallSceneLoader()
        {
            this.Container.Bind<SceneLoader>().AsSingle().NonLazy();
        }

        private void InstallInputSystem()
        {
            this.Container.Bind<InputActions>().AsSingle().NonLazy();
        }
    }
}