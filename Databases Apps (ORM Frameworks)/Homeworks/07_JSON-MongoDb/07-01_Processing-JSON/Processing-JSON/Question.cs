using Newtonsoft.Json;

namespace Processing_JSON
{
    public class Question
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}