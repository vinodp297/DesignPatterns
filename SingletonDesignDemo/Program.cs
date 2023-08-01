namespace SingletonDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configurationManager = ConfigurationManager.GetConfigurationManagerInstance();

            string connection = configurationManager.GetConfigurationSettings("Connectionstring");
            string loglevel = configurationManager.GetConfigurationSettings("Loglevel");
            Console.WriteLine("Connection string : " + connection);
            Console.WriteLine("Loglevel : " + loglevel);
            Console.Read();
        }
    }
}