using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace sportiflix
{
    internal class Filhandling
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/Sportiflix.json";

        public void SaveData(object data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(path,json);

        }

        public T? LoadData <T>()
        {
            string load = File.ReadAllText(path);
            T? data = JsonSerializer.Deserialize<T>(load);
            return data;
        }






    }
}
