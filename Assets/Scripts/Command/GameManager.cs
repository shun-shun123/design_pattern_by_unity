using Command.Interfaces;
using Command.Invoker;
using Command.Receiver;
using UnityEngine;

namespace Command
{

    public class GameManager : MonoBehaviour
    {
        private SimpleRemoteController _simpleRemoteController = new SimpleRemoteController(3);
        
        void Start()
        {
            var lightObj = new Command.Receiver.Light();
            ICommand command = new LightOnCommand(lightObj);
            
            _simpleRemoteController.SetCommand(0, command);
            _simpleRemoteController.CommandExecute(0);
            
            var ceilingFan = new CeilingFan();
            ICommand ceilingFanCommand = new CeilingFanHighCommand(ceilingFan);
            
            _simpleRemoteController.SetCommand(1, ceilingFanCommand);
            _simpleRemoteController.CommandExecute(1);
            _simpleRemoteController.Undo();
            
            var macroCommand = new MacroCommand(new []{command, ceilingFanCommand});
            _simpleRemoteController.SetCommand(2, macroCommand);
            _simpleRemoteController.CommandExecute(2);
            _simpleRemoteController.Undo();
        }
    }
}