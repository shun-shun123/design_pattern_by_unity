using System.Collections.Generic;
using Iterator.Interfaces;
using UnityEngine;

namespace Iterator.Menu
{
    public class LunchMenu : IIterator
    {
        private List<MenuItem> _menuItems = new List<MenuItem>();

        private int _position;

        public LunchMenu()
        {
            _menuItems.Add(new MenuItem("ラーメン", 140));
            _menuItems.Add(new MenuItem("チャーハン", 120));
            _menuItems.Add(new MenuItem("セット", 200));
        }
        
        public bool HasNext()
        {
            if (_position < 0 || _position >= _menuItems.Count || _menuItems[_position] == null)
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