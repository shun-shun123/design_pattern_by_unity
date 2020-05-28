using Iterator.Interfaces;
using Iterator.Menu;
using UnityEngine;

namespace Iterator
{

    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            var diner = new DinerMenu();
            var lunch = new LunchMenu();
            _PrintMenus(diner);
            _PrintMenus(lunch);
        }

        private void _PrintMenus(IIterator iterator)
        {
            var log = "";
            while (iterator.HasNext())
            {
                MenuItem menu = (MenuItem) iterator.Next();
                log = log + $"{menu.Name} (￥{menu.Price})\n";
            }
            Debug.Log(log);
        }
    }
}