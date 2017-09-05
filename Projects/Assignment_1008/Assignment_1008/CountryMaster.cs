using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class CountryMaster: AreaMaster
    {
        public CountryMaster() { }
        public CountryMaster(int id, string code, string name, string description, AreaType areatype, int areaId):base(id,code,name,description,areatype,areaId)
        {
        }
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
        public void GetAreaMasterByCountry(string countryName)
        {
            foreach (AreaMaster country_search in AreaCollection)
            {
                if(country_search.Name==countryName && country_search.Areatype == AreaType.Country)
                {
                    Console.WriteLine($"Country: {country_search.Name}");
                    Console.WriteLine($"Code: {country_search.Code}");
                    Console.WriteLine($"Description: {country_search.Description}");
                }
            }
        }
    }
}
