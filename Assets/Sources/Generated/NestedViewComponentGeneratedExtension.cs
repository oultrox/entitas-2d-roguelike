//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public NestedViewComponent nestedView { get { return (NestedViewComponent)GetComponent(ComponentIds.NestedView); } }

        public bool hasNestedView { get { return HasComponent(ComponentIds.NestedView); } }

        public Entity AddNestedView(string newName) {
            var component = CreateComponent<NestedViewComponent>(ComponentIds.NestedView);
            component.name = newName;
            return AddComponent(ComponentIds.NestedView, component);
        }

        public Entity ReplaceNestedView(string newName) {
            var component = CreateComponent<NestedViewComponent>(ComponentIds.NestedView);
            component.name = newName;
            ReplaceComponent(ComponentIds.NestedView, component);
            return this;
        }

        public Entity RemoveNestedView() {
            return RemoveComponent(ComponentIds.NestedView);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherNestedView;

        public static IMatcher NestedView {
            get {
                if (_matcherNestedView == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.NestedView);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherNestedView = matcher;
                }

                return _matcherNestedView;
            }
        }
    }
}
