namespace FactoryMethod
{
    public class PanelBuilder : CompanyBuilder
    {
        public PanelBuilder(string name) : base(name)
        {
            
        }

        public override House Create()
        {
            Console.Write(base.Name + ": ");
            return new PanelHouse();
        }
    }
}
