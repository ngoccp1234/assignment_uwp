using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Musique.Entity;
using Newtonsoft.Json;


namespace Musique.Service
{
    class SongService: ISongService
    {
        public Song CreateSong(MemberCredential memberCredential, Song song)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(memberCredential.token);
            var dataToSend = JsonConvert.SerializeObject(song);
            var content = new StringContent(dataToSend, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync(ProjectConfiguration.SONG_CREATE_URL, content).
                GetAwaiter().GetResult();
            var jsonContent = response.Content.ReadAsStringAsync().Result;
            var responseSong = JsonConvert.DeserializeObject<Song>(jsonContent);
            Debug.WriteLine("Upload song success with name: " + responseSong.id);
            return responseSong;
        }

        public List<Song> GetAllSong(MemberCredential memberCredential)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(memberCredential.token);
            var response = httpClient.GetAsync(ProjectConfiguration.SONG_GET_ALL).GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<List<Song>>(response.Content.ReadAsStringAsync().Result);
        }

        public List<Song> GetMineSongs(MemberCredential memberCredential)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(memberCredential.token);
            var response = httpClient.GetAsync(ProjectConfiguration.SONG_GET_MINE).GetAwaiter().GetResult();
            var listSong = JsonConvert.DeserializeObject<List<Song>>(response.Content.ReadAsStringAsync().Result);
            return listSong;
        }
    }
}
