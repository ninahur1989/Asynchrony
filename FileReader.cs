using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Asynchrony
{
    public class FileReader
    {
        public string Text { get; set; }

        public async Task<string> HelloReader()
        {
            return await Task.Run(() =>
            {
                var json = JsonConvert.DeserializeObject<FileReader>(File.ReadAllText(@"C:\Users\Admin\source\repos\Asynchrony\Asynchrony\hello_json.json"));
                return json.Text;
            });
        }

        public async Task<string> WorldReader()
        {
            return await Task.Run( () =>
            {
                var json = JsonConvert.DeserializeObject<FileReader>(File.ReadAllText(@"C:\Users\Admin\source\repos\Asynchrony\Asynchrony\world_json.json"));
                return json.Text;
            });
        }

        public async Task<string> Adder()
        {
            Console.WriteLine("start adder");
            return await Task.Run( async () =>
            {
                var a = await HelloReader();
                var b = await WorldReader();

                return a + " " + b;
            });
        }
    }
}
