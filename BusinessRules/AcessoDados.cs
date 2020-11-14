using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using BusinessObjects;

namespace BusinessRules
{
    /// <summary>
    /// Acceses info on data, to interface
    /// </summary>
    public class DataAcess
    {
        /// <summary>
        /// Aux method
        /// </summary>
        /// <returns></returns>
        public static string CheckPath()
        {
            return RestaurantsFound.filePath;
        }

        /// <summary>
        /// Loads Restaurants Found, bases on search
        /// </summary>
        /// <returns></returns>
        public static bool LoadRestaurants()
        {
            return RestaurantsFound.LoadRestaurantsFound();
        }

        /// <summary>
        /// Provides list of restaurants found
        /// </summary>
        /// <returns></returns>
        public static List<RestaurantFoundBO> AcessRestaurantsFound()
        {
            return RestaurantsFound.GetRestaurantsFound();
        }
    }
}
