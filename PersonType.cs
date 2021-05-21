using HotChocolate.Types;

namespace Example
{
    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            descriptor.Field(x => x.Name).Directive<FooDirective>();
        }
    }
}
