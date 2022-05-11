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
      

        public void SaveData(string path, object data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(path,json);

        }

        public T? LoadData <T>(string path)
        {
            string load = File.ReadAllText(path);
            T? data = JsonSerializer.Deserialize<T>(load);
            return data;
        }






    }
}
