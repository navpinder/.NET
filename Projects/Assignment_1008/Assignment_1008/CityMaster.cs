using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class CityMaster:AreaMaster
    {
        public override AreaType Areatype
        {
            get
            {
                return base.Areatype;
            }

            set
            {
                base.Areatype = value;
            }
        }
        public void GetAreaMasterByCity(string cityName)
        {
            foreach (AreaMaster city_search in AreaCollection)
            {
                if (city_search.Name == cityName && city_search.Areatype == AreaType.City)
                {
                    Console.WriteLine($"City: {city_search.Name}");
                    AreaMaster master = new AreaMaster();
                    master.GetNameById(city_search.AreaID);
                    Console.WriteLine($"Code: {city_search.Code}");
                    Console.WriteLine($"Description: {city_search.Description}");
                }
            }
        }
    }
}
