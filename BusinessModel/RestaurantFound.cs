using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessObjects
{
    [Serializable]
    /// <summary>
    /// Contains all restaurants around user's location
    /// </summary>
    public class RestaurantFoundBO
    {
        string nome;
        string distancia;
        int rating;

        [JsonProperty("name")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [JsonProperty("distancia")]
        public string Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }

        [JsonProperty("rating")]
        public int Rating { get { return rating; } set { rating = value; } }
    }
}
