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
        public ComponentWithFields componentWithFields { get { return (ComponentWithFields)GetComponent(ComponentIds.ComponentWithFields); } }

        public bool hasComponentWithFields { get { return HasComponent(ComponentIds.ComponentWithFields); } }

        public Entity AddComponentWithFields(string newPublicField) {
            var component = CreateComponent<ComponentWithFields>(ComponentIds.ComponentWithFields);
            component.publicField = newPublicField;
            return AddComponent(ComponentIds.ComponentWithFields, component);
        }

        public Entity ReplaceComponentWithFields(string newPublicField) {
            var component = CreateComponent<ComponentWithFields>(ComponentIds.ComponentWithFields);
            component.publicField = newPublicField;
            ReplaceComponent(ComponentIds.ComponentWithFields, component);
            return this;
        }

        public Entity RemoveComponentWithFields() {
            return RemoveComponent(ComponentIds.ComponentWithFields);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherComponentWithFields;

        public static IMatcher ComponentWithFields {
            get {
                if (_matcherComponentWithFields == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.ComponentWithFields);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherComponentWithFields = matcher;
                }

                return _matcherComponentWithFields;
            }
        }
    }
}
