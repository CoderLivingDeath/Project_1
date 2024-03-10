using Project.Scripts.Components.SceneLoader;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{

    public override void InstallBindings()
    {
        SceneLoaderInstall();
        //...
#if UNITY_EDITOR
        Debug.Log($"Scene {this.gameObject.scene.name}: {nameof(BootstrapInstaller)} has installed.");
#endif
    }


    public void SceneLoaderInstall()
    {
        this.Container.Bind<SceneLoader>().FromInstance(new SceneLoader());
    }
}