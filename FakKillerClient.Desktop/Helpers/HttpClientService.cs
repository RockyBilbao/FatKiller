using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FatKillerSimpleAdministrator.Service
{
    public static class HttpClientHelper
    {
        public static async Task<string> GetData(string path)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(path);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }
        }

        public static async Task<string> AddData(object dataToAdd, string path)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    //TODO serialize helper
                    var myContent = JsonConvert.SerializeObject(dataToAdd);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);

                    var response = await httpClient.PostAsync(path, byteContent);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }
        }
    }
}
