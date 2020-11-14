using BusinessObjects;
using Newtonsoft.Json;
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

        /// <summary>
        /// Loads all restaurants found
        /// </summary>
        /// <description>
        /// The Deserialize had to be done, separately, 
        /// because when used class RestaurantFound, the results obtained
        /// were only avaliations, while the other informations were being receives
        /// as null / 0 
        /// </description>
        /// <returns></returns>
        public static bool LoadRestaurantsFound()
        {

            if (File.Exists(filePath)) { 
                
                List<RestaurantFound> auxEvaluations = new List<RestaurantFound>();
                List<RestaurantFoundBO> auxRestaurantsInfo = new List<RestaurantFoundBO>();

                // Information load divided in two:  Avaliation / RestaurantFoundBo 
                auxEvaluations = LoadAvaliacoes();
                auxRestaurantsInfo = LoadRestaurantsInfo();
                int i = 0;

                // Merge of both informations, into the definitive list of restaurants
                foreach (RestaurantFound restaurantEv in auxEvaluations)
                {
                    restaurantEv.restaurantFound = auxRestaurantsInfo[i];
                    restaurantsFound.Add(restaurantEv);
                }               
            }
            return true;
        }

        /// <summary>
        /// Loads rates from costumers, for each restaurant found
        /// </summary>
        /// <returns></returns>
        public static List<RestaurantFound> LoadAvaliacoes()
        {
            List<RestaurantFound> restaurantsEvaluations = new List<RestaurantFound>();
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);
                    JsonReader jsonReader = new JsonTextReader(sr);

                    restaurantsEvaluations = jsonSerializer.Deserialize<List<RestaurantFound>>(jsonReader);
                }
                catch (Exception e) { throw e; }
            }
            return restaurantsEvaluations;
        }

        /// <summary>
        /// Loads RestaurantFoundBO part, from main class "RestaurantFound"
        /// </summary>
        /// <returns></returns>
        public static List<RestaurantFoundBO> LoadRestaurantsInfo()
        {
            List<RestaurantFoundBO> restaurantsFoundInfo = new List<RestaurantFoundBO>();
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);
                    JsonReader jsonReader = new JsonTextReader(sr);

                    restaurantsFoundInfo = jsonSerializer.Deserialize<List<RestaurantFoundBO>>(jsonReader);

                    sr.Close();
                    jsonReader.Close();
                        
                }
                catch (Exception e) { throw e; }
            }
            return restaurantsFoundInfo;
        }

    }
}
