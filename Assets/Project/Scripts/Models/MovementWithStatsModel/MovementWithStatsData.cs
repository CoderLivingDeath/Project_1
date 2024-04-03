using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Scripts.Core.Interfaces;
using Project.Scripts.Models.CharacterStatistic;
using Project.Scripts.Models.MovementModel;
using Project.Scripts.Models.MovementWithStatsModel;
using UnityEngine;

namespace Project.Scripts.Models.MovementWithStatsModel
{
    public readonly struct MovementWithStatsData : IMovementData<IMovableWithStats>
    {
        public readonly IMovableWithStats MovableObject { get; }

        public readonly Vector2 Direction { get; }

        public readonly Rigidbody2D Rigidbody { get; }

        public MovementWithStatsData(IMovableWithStats movableObject, Vector2 direction, Rigidbody2D rigidbody)
        {
            MovableObject = movableObject;
            Direction = direction;
            Rigidbody = rigidbody;
        }
    }
}