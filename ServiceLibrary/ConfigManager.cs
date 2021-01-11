using System;

namespace ServiceLibrary
{
    public class ConfigManager : IParser
    {
        IParser parser;

        public ConfigManager(string path, Type mainType)
        {
            if (path.EndsWith(".xml"))
            {
                parser = new XmlParser(path, mainType);
            }
            else if (path.EndsWith(".json"))
            {
                parser = new JsonParser(path, mainType);
            }
            else
            {
                throw new ArgumentNullException($"invalid extension");
            }
        }

        public T GetOptions<T>() => parser.GetOptions<T>();
    }
}
