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
        static readonly ExitComponent exitComponent = new ExitComponent();

        public bool isExit {
            get { return HasComponent(ComponentIds.Exit); }
            set {
                if (value != isExit) {
                    if (value) {
                        AddComponent(ComponentIds.Exit, exitComponent);
                    } else {
                        RemoveComponent(ComponentIds.Exit);
                    }
                }
            }
        }

        public Entity IsExit(bool value) {
            isExit = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherExit;

        public static IMatcher Exit {
            get {
                if (_matcherExit == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Exit);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherExit = matcher;
                }

                return _matcherExit;
            }
        }
    }
}
