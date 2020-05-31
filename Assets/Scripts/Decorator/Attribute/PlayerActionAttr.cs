using Decorator.Interface;

namespace Decorator.Attribute
{
    public abstract class PlayerActionAttr : IPlayerAction
    {
        protected IPlayerAction PlayerAction;
        
        public abstract void Attack();
    }
}