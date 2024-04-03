using UnityEngine;

namespace Project.Scripts.Core.Interfaces
{
    public interface IMovable
    {
        public GameObject GameObject {get;}

        Vector2 MoveVector {get;}
        void Move(Vector2 direction);
    }
}