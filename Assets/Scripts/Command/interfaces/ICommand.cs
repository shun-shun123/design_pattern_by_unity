using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command.Interfaces
{

    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}