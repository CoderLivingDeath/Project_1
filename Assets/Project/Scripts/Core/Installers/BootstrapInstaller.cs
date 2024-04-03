using Project.Scripts.Core.Infrastructure;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Core.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public string NextSceneName;

        [Inject] private SceneLoader _sceneLoader;

        public override void InstallBindings()
        {
            Debug.Log($"{nameof(BootstrapInstaller): has installed.}");
        }

        private new void Start()
        {
            _sceneLoader.Load(NextSceneName);
        }
    }
}