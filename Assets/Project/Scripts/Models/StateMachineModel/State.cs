namespace Project.Scripts.Models.StateMachineModel
{
    public abstract class State : IState
    {
        public virtual void Enter() {}
        public virtual void Stay() {}
        public virtual void Exit() {}
    }
}