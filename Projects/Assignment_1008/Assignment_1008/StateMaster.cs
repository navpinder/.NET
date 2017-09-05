using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class StateMaster:AreaMaster
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
        public void GetAreaMasterByState(string stateName)
        {
            foreach (AreaMaster state_search in AreaCollection)
            {
                if (state_search.Name == stateName && state_search.Areatype == AreaType.State)
                {
                   Console.WriteLine($"State: {state_search.Name}");
                    AreaMaster master = new AreaMaster();
                    master.GetNameById(state_search.AreaID);
                    Console.WriteLine($"Code: {state_search.Code}");
                    Console.WriteLine($"Description: {state_search.Description}");
                }
            }
        }
    }
}
