using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class ApiCommunicator
    {
        const string baseUrl = "https://generator20221016203403.azurewebsites.net/"; //"https://contentgenerator.azurewebsites.net/"; // bogustitlesgr?count=10";
        public static async Task<string> GetJobTitle(string lang = "")
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync($"{baseUrl}bogustitle{lang}");
        }

        public static async Task<string> GetPoliticalSpeech()
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync($"{baseUrl}woodenlanguagegr");
        }
    }
