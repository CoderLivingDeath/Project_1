using System;
using Project.Scripts.Core.Interfaces;
using UnityEngine;

namespace Project.Scripts.Models.MovementModel
{
    public abstract class IMovementHandler<TData> where TData : IMovementData<IMovable>
    {
        public event Action<MoveEventArg> OnMoveEvent;

        public abstract void Move(TData data);

        public abstract Vector2 CalculateNewPosition(TData data);
        protected void OnMove(MoveEventArg arg)
        {
            OnMoveEvent?.Invoke(arg);
        }
    }
}