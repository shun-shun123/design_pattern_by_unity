using System.Collections;
using System.Collections.Generic;
using Command.Interfaces;
using UnityEngine;

namespace Command.Invoker
{

    public class SimpleRemoteController
    {
        private ICommand[] _command;

        private ICommand _undoCommand;

        public SimpleRemoteController(int slotSize)
        {
            _command = new ICommand[slotSize];
        }

        public void SetCommand(int slot, ICommand command)
        {
            _command[slot] = command;
        }

        public void CommandExecute(int slot)
        {
            _command[slot].Execute();
            _undoCommand = _command[slot];
        }

        public void Undo()
        {
            _undoCommand.Undo();
        }
    }
}