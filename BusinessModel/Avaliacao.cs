using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Describes an evaluation of a restaurant
    /// </summary>
    public class Avaliacao
    {
        string comentario;
        int rating;   
         
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

    }
}
