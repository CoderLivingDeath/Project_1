using Project.Scripts.Core.Interfaces;
using UnityEngine;

namespace Project.Scripts.Models.MovementModel
{
    public interface IMovementData<out TMovableObj> where TMovableObj : IMovable
    {
        public TMovableObj MovableObject {get;}
        public  Vector2 Direction {get;}
    }
}