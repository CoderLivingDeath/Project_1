using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

namespace Project.Scripts.Core.API.Structures
{
    public class InputEvents
    {
        public event Action<InputEventCallbackContext> OnStarted;
        public event Action<InputEventCallbackContext> OnPerformed;
        public event Action<InputEventCallbackContext> OnCanceled;

        internal InputEvents()
        {
            
        }

        internal void Started(InputEventCallbackContext Context)
        {
            OnStarted?.Invoke(Context);
        }

        internal void Performed(InputEventCallbackContext Context)
        {
            OnPerformed?.Invoke(Context);
        }

        internal void Canceled(InputEventCallbackContext Context)
        {
            OnCanceled?.Invoke(Context);
        }
    }
}


