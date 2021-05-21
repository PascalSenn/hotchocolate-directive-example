using HotChocolate.Types;

namespace hotchocolate_directive_example
{
    public class FooDirectiveType : DirectiveType<FooDirective>
    {
        protected override void Configure(IDirectiveTypeDescriptor<FooDirective> descriptor)
        {
            descriptor.Name("Foo");
            descriptor.Location(DirectiveLocation.FieldDefinition);
            descriptor.Use<FooMiddleware>();
        }
    }
}