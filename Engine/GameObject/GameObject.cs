using System.Collections.Generic;
using System.Linq;
using Engine.Components;

namespace Engine.GameObject
{
    class GameObject
    {
        private readonly List<Component> _allComponents = new List<Component>(); 

        public GameObject(Transform transform)
        {
            _allComponents.Add(transform);
        }

        public Component GetComponent(Component findComponent)
        {
            Component returnComponent = null;

            foreach (var component in _allComponents.Where(component => component.GetType() == findComponent.GetType()))
            {
                returnComponent = component;
            }

            return returnComponent;
        }
    }
}
