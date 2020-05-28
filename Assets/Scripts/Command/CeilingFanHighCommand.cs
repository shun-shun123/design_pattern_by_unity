using Command.Interfaces;
using Command.Receiver;
using UnityEngine;

namespace Command
{

    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
            Debug.Log("CeilingFanCommand Executed");
        }

        public void Undo()
        {
            Debug.Log("Undo");
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            } else if (_prevSpeed == CeilingFan.MIDDLE)
            {
                _ceilingFan.Middle();
            } else if (_prevSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            } else if (_prevSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}