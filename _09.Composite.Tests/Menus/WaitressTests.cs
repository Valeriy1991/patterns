using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using _09.Composite.Menus;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Tests.Menus
{
    [ExcludeFromCodeCoverage]
    [Trait("Category", "Unit")]
    public class WaitressTests
    {
        private Waitress CreateTestedComponent(MenuComponent menu)
        {
            return new Waitress(menu);
        }

        public static IEnumerable<object[]> MenuTree = new List<object[]>()
        {
            new object[] {CreateSimpleMenu()},
            new object[] {CreateRealMenu()}
        };

        private static Menu CreateSimpleMenu()
        {
            var menuItem1 = new MenuItem("item-1", "desc-1", false, 0.1m);
            var menuItem2 = new MenuItem("item-2", "desc-2", false, 0.2m);
            var menuItem3 = new MenuItem("item-3", "desc-3", false, 0.3m);
            var menuItem4 = new MenuItem("item-4", "desc-4", true, 0.4m);
            var menuItem5 = new MenuItem("item-5", "desc-5", true, 0.5m);

            var subSubMenuItem1 = new MenuItem("item-6-1-1", "desc-6-1-1", true, 0.001m);
            var subSubMenuItem2 = new MenuItem("item-6-1-2", "desc-6-1-2", false, 0.002m);
            var subMenu1 = new Menu("item-6-1", "desc-6-1");
            subMenu1.Add(subSubMenuItem1);
            subMenu1.Add(subSubMenuItem2);

            var subMenuItem2 = new MenuItem("item-6-2", "desc-6-2", true, 0.02m);
            var subMenuItem3 = new MenuItem("item-6-3", "desc-6-3", false, 0.03m);
            var menuItem6WithSubMenu = new Menu("item-6", "desc-6");
            menuItem6WithSubMenu.Add(subMenu1);
            menuItem6WithSubMenu.Add(subMenuItem2);
            menuItem6WithSubMenu.Add(subMenuItem3);

            var menu = new Menu("menu", "desc");
            menu.Add(menuItem1);
            menu.Add(menuItem2);
            menu.Add(menuItem3);
            menu.Add(menuItem4);
            menu.Add(menuItem5);
            menu.Add(menuItem6WithSubMenu);

            return menu;
        }

        private static Menu CreateRealMenu()
        {
            return MenuFactory.Create();
        }

        [Theory]
        [MemberData(nameof(MenuTree))]
        public void PrintVegetarianMenu__DoesNotThrowAnyException(Menu menu)
        {
            // Arrange
            var waitress = CreateTestedComponent(menu);
            Action act = () => waitress.PrintVegetarianMenu();
            // Act
            var ex = Record.Exception(act);
            // Assert
            Assert.Null(ex);
        }
    }
}