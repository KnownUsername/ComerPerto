using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        //List<Avaliacao> avaliacoes = new List<Avaliacao>();

        //public List<Avaliacao> Avaliacoes { get; set; }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
        public int Rating { get { return rating; } set { rating = value; } }
    }
}
