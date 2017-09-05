using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class AreaMaster
    {
        public AreaMaster() { }
        public AreaMaster(int id,string code,string name,string description,AreaType areatype,int areaId)
        {
            ID = id;
            Code = code;
            Name = name;
            Description = description;
            Areatype = areatype;
            AreaID = areaId;
            AreaCollection.Add(this);
        }
        public enum AreaType { Country = 1, State, City, District };
        //int id, areaId;
        //string code, name, description;
        //AreaType areatype;
        protected static List<AreaMaster> AreaCollection = new List<AreaMaster>();
        public int ID
        {
            get;
            set;           
        }
        public string Code
        {
            get;
            set;        
        }
        public string Name
        {
            get;
            set;            
        }
        public string Description
        {
            get;
            set;            
        }
        public virtual AreaType Areatype
        {
            get;
            set;            
        }
        public int AreaID
        {
            get;
            set;            
        }
        public void GetNameById(int id)
        {
            foreach (AreaMaster searchById in AreaCollection)
            {
                if (searchById.ID == id)
                {
                    string name= searchById.Name;
                    
                    if (searchById.Areatype == AreaType.City)
                    {
                        Console.WriteLine($"City: {name}");
                        GetNameById(searchById.AreaID);
                    }
                    else if(searchById.Areatype == AreaType.State)
                    {
                        Console.WriteLine($"State: {name}");
                        GetNameById(searchById.AreaID);

                    }
                    else if(searchById.Areatype == AreaType.Country)
                    {
                        Console.WriteLine($"Country: {name}");        
                    }                  
                }               
            }
        }
    }    
}
