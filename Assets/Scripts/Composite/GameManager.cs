using System;
using Composite.Abstract;
using Composite.Menu;
using UnityEngine;

namespace Composite
{

    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            var pancakeHouseMenu = new Menu.Menu("パンケーキハウスメニュー", "朝食");
            var dinerMenu = new Menu.Menu("食堂メニュー", "昼食");
            var cafeMenu = new Menu.Menu("カフェメニュー", "夕食");
            var dessertMenu = new Menu.Menu("デザートメニュー", "デザート");
            
            MenuComponent allMenus = new Menu.Menu("全てのメニュー", "管理している全てのメニューです");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("パスタ", "マリナラソースのかかったスパゲティとサワードーパン", true, 3.89));
            
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("アップルパイ", "バニラアイスクリームをのせたフレーク状生地のアップルパイ", true, 1.59));

            allMenus.Print();
        }
    }
}