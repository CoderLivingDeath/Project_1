using Project.Scripts.Core.Infrastructure;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Core.Installers
{
    public class LoadingInstaller : MonoInstaller
    {
        public string NextSceneName;

        [Inject] private SceneLoader _sceneLoader;
        [Inject] private InputActions _inputActions;

        public override void InstallBindings()
        {
            _inputActions.Enable();
            Debug.Log($"{nameof(LoadingInstaller): has installed.}");

        }

        private new void Start()
        {
            _sceneLoader.Load(NextSceneName);
        }
    }
}