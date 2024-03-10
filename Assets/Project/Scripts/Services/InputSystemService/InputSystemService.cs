using Project.Scripts.Core.API.Infrastructure;
using Project.Scripts.Core.API.Infrastructure.Factory;
using Project.Scripts.Core.API.Services;
using Project.Scripts.Core.API.Structures;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;
using System;

namespace Project.Scripts.AssemblyDefinitions.Services
{
    public class InputSystemService : IInputService, IInitializable
    {
        public Dictionary<string, InputEvents> InputMap { get;}

        private InputActions _inputActions;

        private IFactory<InputEvents, InpuEventsFactoryArgs> _inputEventsFactory;

        public InputSystemService(InputActions inputActions)
        {
            _inputActions = inputActions;
            _inputActions.Enable();
            InputMap = new Dictionary<string, InputEvents>();
            _inputEventsFactory = new InputEventsFactory();
        }

        // TODO: инициализация InputKeys
        public void Initialize()
        {
            InputMap.Add(InputKeys.MouseClick, RegistrateInputEvents<Vector2>(_inputActions.Gameplay.MouseDelta));
            InputMap.Add(InputKeys.Movement, RegistrateInputEvents<Vector2>(_inputActions.Gameplay.Movement));
            //...
        }

        internal InputEvents RegistrateInputEvents<T>(InputAction action) where T: struct
        {
            Type type = typeof(T);

            Action<Action<InputEventCallbackContext>> Started = StartedEventHandler =>
            {
                action.started += (contenxt) => StartedEventHandler.Invoke(new InputEventCallbackContext(contenxt.ReadValue<T>(), type));
            };

            Action<Action<InputEventCallbackContext>> Performed = PerformedEventHandler =>
            {
                action.performed += (contenxt) => PerformedEventHandler.Invoke(new InputEventCallbackContext(contenxt.ReadValue<T>(), type));
            };

            Action<Action<InputEventCallbackContext>> Canceled = CanceledEventHandler =>
            {
                action.canceled += (contenxt) => CanceledEventHandler.Invoke(new InputEventCallbackContext(contenxt.ReadValue<T>(), type));
            };

            InpuEventsFactoryArgs arg = new InpuEventsFactoryArgs(type,Started,Performed,Canceled);

            return _inputEventsFactory.Create(arg);
        }
    }
}
