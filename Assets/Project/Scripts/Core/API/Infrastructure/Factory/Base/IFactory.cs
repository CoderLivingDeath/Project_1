using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Scripts.Core.API.Infrastructure.Factory
{
    public interface IFactory<TValue>
    {
        public TValue Create();
    }

    public interface IFactory<TValue, TArg>
    {
        public TValue Create(TArg arg);
    }

    public interface IFactory<TValue, TArg1, TArg2>
    {
        public TValue Create(TArg1 arg1, TArg2 arg2);
    }
}
