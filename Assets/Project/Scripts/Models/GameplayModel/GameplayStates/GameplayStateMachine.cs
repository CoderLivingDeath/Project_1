using Project.Scripts.Core.Infrastructure.Factory.BaseFactory;
using Project.Scripts.Models.StateMachineModel;

namespace Project.Scripts.Models.GameplayModel.GameStates
{
    public class GameplayStateMachine : StateMachine
    {
        public class GameStateMachineFactory : IFactory<GameplayStateMachine>
        {
            public GameplayStateMachine Create() => new GameplayStateMachine();
        }

        public GameplayStateMachine()
        {

        }
    }
}