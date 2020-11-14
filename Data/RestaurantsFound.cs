using BusinessObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Data
{
    /// <summary>
    /// Restaurant found with its evaluations
    /// </summary>
    public class RestaurantFound
    {
        public RestaurantFoundBO restaurantFound = new RestaurantFoundBO();
        public List<Avaliacao> avaliacoes = new List<Avaliacao>();

    }

    public static class RestaurantsFound
    {
        static List<RestaurantFound> restaurantsFound = new List<RestaurantFound>();

        public static string filePath = "..//..//..//..//restaurantesEnZona.json";

        public static List<RestaurantFoundBO> GetRestaurantsFound()
        {
            List<RestaurantFoundBO> restaurantsBasic = new List<RestaurantFoundBO>();
            foreach (RestaurantFound restaurant in restaurantsFound)
            {
                restaurantsBasic.Add(restaurant.restaurantFound);
            }
            return restaurantsBasic;
        }

        public static bool LoadRestaurantsFound()
        {
            List<RestaurantFoundBO> aux = new List<RestaurantFoundBO>();
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);
                    JsonReader jsonReader = new JsonTextReader(sr);
                    restaurantsFound = jsonSerializer.Deserialize<List<RestaurantFound>>(jsonReader);

                    //aux = jsonSerializer.Deserialize<List<RestaurantFoundBO>>(jsonReader);
                    jsonReader.Close();
                    sr.Close();

                    return true;
                }
                catch (Exception e) { throw e; }
            }
            return false;
        }

    }
}
