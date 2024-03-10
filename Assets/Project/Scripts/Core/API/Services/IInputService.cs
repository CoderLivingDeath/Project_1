using Project.Scripts.Core.API.Structures;
using System.Collections.Generic;

namespace Project.Scripts.Core.API.Services
{
    public interface IInputService
    {
        public Dictionary<string, InputEvents> InputMap { get;}
    }
}
