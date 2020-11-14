using System;

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
