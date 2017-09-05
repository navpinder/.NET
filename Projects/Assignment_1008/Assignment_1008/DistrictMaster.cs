using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class DistrictMaster:AreaMaster
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
        public void GetAreaMasterByDistrict(string districtName)
        {
            foreach (AreaMaster district_search in AreaCollection)
            {
                if (district_search.Name == districtName && district_search.Areatype == AreaType.District)
                {
                    Console.WriteLine($"District: {district_search.Name}");
                    AreaMaster master = new AreaMaster();
                    master.GetNameById(district_search.AreaID);
                    Console.WriteLine($"Code: {district_search.Code}");
                    Console.WriteLine($"Description: {district_search.Description}");
                }
            }
        }
    }
}
