using System;
using Iterator.Interfaces;

namespace Iterator.Menu
{

    public class DinerMenu : IIterator
    {
        private MenuItem[] _menuItems;
        
        private int _position;

        public DinerMenu()
        {
            _menuItems = new MenuItem[3];
            _menuItems[0] = new MenuItem("スープ", 100);
            _menuItems[1] = new MenuItem("ご飯", 200);
            _menuItems[2] = new MenuItem("デザート", 150);
        }
        
        public bool HasNext()
        {
            if (_position < 0 || _position >= _menuItems.Length || _menuItems[_position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var menu = _menuItems[_position];
            _position++;
            return menu;
        }
    }
}