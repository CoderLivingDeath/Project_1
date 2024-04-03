using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Scripts.Models.StateMachineModel
{
    public abstract class StateMachine
    {
        public IState CurrentState { get; private set; }

        private Dictionary<Type, IState> _registredStates;

        public IEnumerable<IState> RegistredStates => _registredStates.Select(x => x.Value);
        
        public event Action<IState> StateChanged;

        public void RegisterState<T>(T state) where T : IState
        {
            _registredStates.Add(state.GetType(), state);
        }

        public void SetState<T>() where T : IState
        {
            var type = typeof(T);

            if(CurrentState != null && type == CurrentState.GetType()) return;

            if(_registredStates.TryGetValue(type, out var newState))
            {
                CurrentState?.Exit();

                CurrentState = newState;

                newState?.Enter();

                StateChanged?.Invoke(newState);
            }
        }
    }
}