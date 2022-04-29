
namespace FactoryMethod
{
    public abstract class CompanyBuilder
    {
        public string Name { get; set; }

        public CompanyBuilder(string name)
        {
            Name = name;
        }

        public abstract House Create();
    }
}
