namespace Singlton
{
    public class OS
    { 

        private static OS? _instance;

        public string Name { get; set; }

        protected OS(string name)
        {
            Name = name;
        }

        public static OS GetOS(string name)
        {
            if (_instance == null)
                return new OS(name);
            return _instance;
        }
    }
}