using System;

namespace FactoryMethod
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            var panel = new PanelBuilder("ООО СельмашСтрой");
            var wood = new WoodBuilder("ООО Деревянный ЮГ");

            panel.Create();
            wood.Create();
        }
    }
}