using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Scripts.Models.StateMachineModel
{
    public interface IState
    {
        void Enter();
        void Stay();
        void Exit();
    }
}