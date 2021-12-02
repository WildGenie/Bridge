using System.Globalization;

namespace System.Reflection.Emit {

    public class EnumBuilder {
        public virtual Assembly Assembly => default( Assembly );

        public virtual string AssemblyQualifiedName => default( string );

        public virtual Type BaseType => default( Type );

        public virtual Type DeclaringType => default( Type );

        public virtual string FullName => default( string );

        public virtual Guid GUID => default( Guid );

        public virtual Module Module => default( Module );

        public virtual string Name => default( string );

        public virtual string Namespace => default( string );

        public virtual Type ReflectedType => default( Type );

        public TypeToken TypeToken => default( TypeToken );

        public FieldBuilder UnderlyingField => default( FieldBuilder );

        public virtual Type UnderlyingSystemType => default( Type );

        public virtual bool IsConstructedGenericType => default( bool );

        public Type CreateType() {
            return default( Type );
        }

        public TypeInfo CreateTypeInfo() {
            return default( TypeInfo );
        }

        public virtual Type GetEnumUnderlyingType() {
            return default( Type );
        }

        public FieldBuilder DefineLiteral( string literalName, object literalValue ) {
            return default( FieldBuilder );
        }

        public virtual ConstructorInfo[] GetConstructors( BindingFlags bindingAttr ) {
            return default( ConstructorInfo[] );
        }

        public virtual object[] GetCustomAttributes( bool inherit ) {
            return default( object[] );
        }

        public virtual object[] GetCustomAttributes( Type attributeType, bool inherit ) {
            return default( object[] );
        }

        public virtual Type GetElementType() {
            return default( Type );
        }

        public virtual EventInfo GetEvent( string name, BindingFlags bindingAttr ) {
            return default( EventInfo );
        }

        public virtual EventInfo[] GetEvents() {
            return default( EventInfo[] );
        }

        public virtual EventInfo[] GetEvents( BindingFlags bindingAttr ) {
            return default( EventInfo[] );
        }

        public virtual FieldInfo GetField( string name, BindingFlags bindingAttr ) {
            return default( FieldInfo );
        }

        public virtual FieldInfo[] GetFields( BindingFlags bindingAttr ) {
            return default( FieldInfo[] );
        }

        public virtual Type GetInterface( string name, bool ignoreCase ) {
            return default( Type );
        }

        public virtual InterfaceMapping GetInterfaceMap( Type interfaceType ) {
            return default( InterfaceMapping );
        }

        public virtual Type[] GetInterfaces() {
            return default( Type[] );
        }

        public virtual MemberInfo[] GetMember( string name, MemberTypes type, BindingFlags bindingAttr ) {
            return default( MemberInfo[] );
        }

        public virtual MemberInfo[] GetMembers( BindingFlags bindingAttr ) {
            return default( MemberInfo[] );
        }

        public virtual MethodInfo[] GetMethods( BindingFlags bindingAttr ) {
            return default( MethodInfo[] );
        }

        public virtual Type GetNestedType( string name, BindingFlags bindingAttr ) {
            return default( Type );
        }

        public virtual Type[] GetNestedTypes( BindingFlags bindingAttr ) {
            return default( Type[] );
        }

        public virtual PropertyInfo[] GetProperties( BindingFlags bindingAttr ) {
            return default( PropertyInfo[] );
        }

        public virtual object InvokeMember( string name, BindingFlags invokeAttr, Binder binder, object target,
            object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters ) {
            return default( object );
        }

        public virtual bool IsDefined( Type attributeType, bool inherit ) {
            return default( bool );
        }

        public virtual Type MakeArrayType() {
            return default( Type );
        }

        public virtual Type MakeArrayType( int rank ) {
            return default( Type );
        }

        public virtual Type MakeByRefType() {
            return default( Type );
        }

        public virtual Type MakePointerType() {
            return default( Type );
        }

        public void SetCustomAttribute( CustomAttributeBuilder customBuilder ) { }
        public void SetCustomAttribute( ConstructorInfo con, byte[] binaryAttribute ) { }

        public virtual bool IsAssignableFrom( TypeInfo typeInfo ) {
            return default( bool );
        }
    }

}
