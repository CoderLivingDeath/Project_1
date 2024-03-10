using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Scripts.Core.API.Structures
{
    public struct InputEventCallbackContext
    {
        public object Value { get; }
        public Type ValueType {  get; }

        public InputEventCallbackContext(object value, Type type)
        {
            Value = value; ValueType = type;
        }

        public T ReadValue<T>()
        {
            return (T)Value;
        }
    }
}
