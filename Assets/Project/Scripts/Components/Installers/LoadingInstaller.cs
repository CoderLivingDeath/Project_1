using Project.Scripts.Components.SceneLoader;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LoadingInstaller : MonoInstaller
{
    [SerializeField] private string _nextScene;

    [Inject] private SceneLoader _loader;

    private new void Start()
    {
        _loader.Load(_nextScene);
    }

    public override void InstallBindings()
    {
#if UNITY_EDITOR
        Debug.Log($"Scene {this.gameObject.scene.name}: {nameof(LoadingInstaller)} has installed.");
#endif
    }
}