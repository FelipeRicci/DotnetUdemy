using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{

    public class PersonVO
    {
        //Um exemplo apenas para mostrar como voce pode customizar os atributos da classe
        [JsonPropertyName("code")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonIgnore]
        public string Address { get; set; }

        [JsonPropertyName("sex")]
        public string Gender { get; set; }
    }
}
