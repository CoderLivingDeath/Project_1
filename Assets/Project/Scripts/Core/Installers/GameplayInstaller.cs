using System;
using Project.Scripts.Configs;
using Project.Scripts.Core.Infrastructure.Factory.BaseFactory;
using Project.Scripts.Models.CharacterModel;
using UnityEngine;
using Zenject;
namespace Project.Scripts.Core.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public PlayerConfig playerConfig;

        public override void InstallBindings()
        {
            InstallPlayerConfig();
            InstallPlayerFactory();
            InstallPayer();

            Debug.Log($"{nameof(GameplayInstaller): has installed.}");
        }


        private void InstallPlayerConfig()
        {
            this.Container.Bind<PlayerConfig>().FromScriptableObject(playerConfig).AsSingle();
        }

        private void InstallPlayerFactory()
        {
        }

        private void InstallPayer()
        {
        }
    }
}