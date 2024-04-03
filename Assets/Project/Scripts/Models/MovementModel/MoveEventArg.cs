using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Scripts.Core.Interfaces;
using UnityEngine;

namespace Project.Scripts.Models.MovementModel
{
    public class MoveEventArg : EventArgs
    {
        public readonly IMovementData<IMovable> movementData;
        public readonly Vector2 PreviousPosition;

        public MoveEventArg(IMovementData<IMovable> movementData, Vector2 previousPosition)
        {
            this.movementData = movementData;
            PreviousPosition = previousPosition;
        }
    }
}