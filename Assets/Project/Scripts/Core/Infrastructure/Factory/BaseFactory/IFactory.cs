namespace Project.Scripts.Core.Infrastructure.Factory.BaseFactory
{
    public interface IFactory
    {
        
    }

    public interface IFactory<out T> : IFactory
    {
        T Create();
    }

    public interface IFactory<out T, TArg> : IFactory
    {
        T Create(TArg arg);
    }

    public interface IFactory<out T, TArg1, TArg2> : IFactory
    {
        T Create(TArg1 arg1, TArg2 arg2);
    }

    public interface IFactory<out T, TArg1, TArg2, TArg3> : IFactory
    {
        T Create(TArg1 arg1, TArg2 arg2, TArg3 arg3);
    }

    public interface IFactory<out T, TArg1, TArg2, TArg3, TArg4> : IFactory
    {
        T Create(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);
    }

    public interface IFactory<out T, TArg1, TArg2, TArg3, TArg4, TArg5> : IFactory
    {
        T Create(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);
    }
}