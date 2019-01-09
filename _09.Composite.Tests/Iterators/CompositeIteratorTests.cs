using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using _09.Composite.Iterators;
using _09.Composite.Menus;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Tests.Iterators
{
    [ExcludeFromCodeCoverage]
    [Trait("Category", "Unit")]
    public class CompositeIteratorTests
    {
        private CompositeIterator CreateTestedComponent(IEnumerator<MenuComponent> enumerator)
        {
            return new CompositeIterator(enumerator);
        }

        private readonly List<MenuComponent> _menuComponents;
        private CompositeIterator _iterator;

        public CompositeIteratorTests()
        {
            _menuComponents = new List<MenuComponent>();
        }

        [Fact]
        public void Current__MenuIsEmpty__ReturnNull()
        {
            // Arrange
            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            // Act
            var current = _iterator.Current;
            // Assert
            Assert.Null(current);
        }
        [Fact]
        public void MoveNext__MenuIsEmpty__ReturnFalse()
        {
            // Arrange
            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            // Act
            var wasMoved = _iterator.MoveNext();
            // Assert
            Assert.False(wasMoved);
        }

        [Fact]
        public void Current__MenuIsNotEmpty__ReturnFirstMenuItem()
        {
            // Arrange
            var menuItem1 = new MenuItem("menu-item-1", "desc-1", false, 0.1m);
            _menuComponents.Add(menuItem1);

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            // Act
            var current = _iterator.Current;
            // Assert
            Assert.Equal(menuItem1.GetName(), current.GetName());
        }
        [Fact]
        public void MoveNext__MenuIsNotEmpty__ReturnTrue()
        {
            // Arrange
            var menu = new Menu("menu-1", "menu-desc-1");
            _menuComponents.Add(menu);

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            // Act
            var wasMoved = _iterator.MoveNext();
            // Assert
            Assert.True(wasMoved);
        }

        [Fact]
        public void Current__MenuContains3MenuItems_MoveNext2Times__Return3rdMenuItem()
        {
            // Arrange
            var menuItem1 = new MenuItem("menu-item-1", "desc-1", false, 0.1m);
            var menuItem2 = new MenuItem("menu-item-2", "desc-2", false, 0.2m);
            var menuItem3 = new MenuItem("menu-item-3", "desc-3", false, 0.3m);
            _menuComponents.Add(menuItem1);
            _menuComponents.Add(menuItem2);
            _menuComponents.Add(menuItem3);

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            _iterator.MoveNext();
            _iterator.MoveNext();
            // Act
            var current = _iterator.Current;
            // Assert
            Assert.Equal(menuItem3.GetName(), current.GetName());
        }
        [Fact]
        public void MoveNext__MenuContains3MenuItems_MoveNext2Times__ReturnTrue()
        {
            // Arrange
            var menuItem1 = new MenuItem("menu-item-1", "desc-1", false, 0.1m);
            var menuItem2 = new MenuItem("menu-item-2", "desc-2", false, 0.2m);
            var menuItem3 = new MenuItem("menu-item-3", "desc-3", false, 0.3m);
            _menuComponents.Add(menuItem1);
            _menuComponents.Add(menuItem2);
            _menuComponents.Add(menuItem3);

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            _iterator.MoveNext();
            _iterator.MoveNext();
            // Act
            var wasMoved = _iterator.MoveNext();
            // Assert
            Assert.True(wasMoved);
        }
        [Fact]
        public void MoveNext__MenuContains3MenuItems_MoveNext3Times__ReturnFalse()
        {
            // Arrange
            var menuItem1 = new MenuItem("menu-item-1", "desc-1", false, 0.1m);
            var menuItem2 = new MenuItem("menu-item-2", "desc-2", false, 0.2m);
            var menuItem3 = new MenuItem("menu-item-3", "desc-3", false, 0.3m);
            _menuComponents.Add(menuItem1);
            _menuComponents.Add(menuItem2);
            _menuComponents.Add(menuItem3);

            IEnumerator<MenuComponent> enumerator = _menuComponents.GetEnumerator();
            _iterator = CreateTestedComponent(enumerator);
            _iterator.MoveNext();
            _iterator.MoveNext();
            _iterator.MoveNext();
            // Act
            var wasMoved = _iterator.MoveNext();
            // Assert
            Assert.False(wasMoved);
        }
    }
}