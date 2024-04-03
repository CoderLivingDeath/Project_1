using Project.Scripts.Models.MovementWithStatsModel;
using Project.Scripts.Models.MovementModel;
using UnityEngine;
using Project.Scripts.Core.Interfaces;

namespace Project.Scripts.Models.MovementWithStatsModel
{
    public class MovementHandlerWithStats : IMovementHandler<MovementWithStatsData>
    {
        public override Vector2 CalculateNewPosition(MovementWithStatsData data)
        {
            var offset = data.Direction * Time.deltaTime * data.MovableObject.ActualStats.Dexterity;
            var NewPosition = data.Rigidbody.position + offset;

            return NewPosition;
        }

        public override void Move(MovementWithStatsData data)
        {
            data.Rigidbody.MovePosition(CalculateNewPosition(data));

            MoveEventArg eventArg = new(data, data.Rigidbody.position);
            OnMove(eventArg);
        }
    }
}