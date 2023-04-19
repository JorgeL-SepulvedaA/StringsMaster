using StringMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    public class ChordAPI
    {
        static HttpClient client = new HttpClient();
        public async Task<chord> GetChord(string acorde)
        {
            client.BaseAddress = new Uri("https://api.uberchord.com/v1/chords/");
            var responseTask = client.GetAsync(acorde);
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<chord[]>();
                readTask.Wait();
                var chords = readTask.Result;
                chord chord = chords[0];
                return chord;
            }
            return null;
        }

    }
}
