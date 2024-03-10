using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
#if UNITY_EDITOR
        Debug.Log($"Scene {this.gameObject.scene.name}: {nameof(GameplayInstaller)} has installed.");
#endif
    }
}