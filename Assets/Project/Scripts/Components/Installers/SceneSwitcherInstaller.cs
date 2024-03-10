using Project.Scripts.Components.SceneLoader;
using UnityEngine;
using Zenject;

public class SceneSwitcherInstaller : MonoInstaller
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
        Debug.Log($"Scene {this.gameObject.scene.name}: {nameof(SceneSwitcherInstaller)} has installed.");
#endif
    }
}