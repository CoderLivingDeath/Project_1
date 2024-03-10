using Project.Scripts.Core.API.Infrastructure.Factory;
using Project.Scripts.Core.API.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Scripts.Core.API.Infrastructure.Factory
{
    public class InputEventsFactory : IFactory<InputEvents, InpuEventsFactoryArgs>
    {
        public InputEvents Create(InpuEventsFactoryArgs arg)
        {
            InputEvents inputEvents = new InputEvents();
            arg.Started.Invoke(inputEvents.Started);
            arg.Performed.Invoke(inputEvents.Performed);
            arg.Canceled.Invoke(inputEvents.Canceled);
            return inputEvents;
        }
    }

    public struct InpuEventsFactoryArgs
    {
        public readonly Type Type;

        public readonly Action<Action<InputEventCallbackContext>> Started;
        public readonly Action<Action<InputEventCallbackContext>> Performed;
        public readonly Action<Action<InputEventCallbackContext>> Canceled;

        public InpuEventsFactoryArgs(Type type,Action<Action<InputEventCallbackContext>> started, Action<Action<InputEventCallbackContext>> performed, Action<Action<InputEventCallbackContext>> canceled)
        {
            Type = type;

            Started = started;
            Performed = performed;
            Canceled = canceled;
        }
    }
}
