using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("Enter 1 for entering the data, 2 for searching and anyother key for exit");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Enter data:");
                    Console.WriteLine("ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Name:");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Code");
                    string code = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Description");
                    string description = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Area Type:");
                    int areatype = Convert.ToInt32(Console.ReadLine());
                    AreaMaster.AreaType area = (AreaMaster.AreaType)areatype;
                    Console.WriteLine("Area Id");
                    int areaid = Convert.ToInt32(Console.ReadLine());
                    AreaMaster master = new AreaMaster(id, code, name, description, area, areaid);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter:");
                    Console.WriteLine("1.For Search By Country");
                    Console.WriteLine("2.For Search By State");
                    Console.WriteLine("3.For Search By City");
                    Console.WriteLine("4.For Search By District");
                    int searchInput = Convert.ToInt32(Console.ReadLine());
                    switch (searchInput)
                    {
                        case 1:
                            CountryMaster country_master = new CountryMaster();
                            Console.WriteLine("Enter the name of Country:");
                            string country_search = Convert.ToString(Console.ReadLine());
                            country_master.GetAreaMasterByCountry(country_search);
                            break;
                        case 2:
                            StateMaster state_master = new StateMaster();
                            Console.WriteLine("Enter the name of Sate:");
                            string state_search = Convert.ToString(Console.ReadLine());
                            state_master.GetAreaMasterByState(state_search);
                            break;
                        case 3:
                            CityMaster city_master = new CityMaster();
                            Console.WriteLine("Enter the name of City:");
                            string city_search = Convert.ToString(Console.ReadLine());
                            city_master.GetAreaMasterByCity(city_search);
                            break;
                        case 4:
                            DistrictMaster district_master = new DistrictMaster();
                            Console.WriteLine("Enter the name of Country:");
                            string district_search = Convert.ToString(Console.ReadLine());
                            district_master.GetAreaMasterByDistrict(district_search);
                            break;
                        default:
                            Console.WriteLine("You Entered Wrong Command");
                            break;

                    }
                    Console.ReadLine();
                }
                else
                    Console.ReadLine();
                
            } while (input != 3);
          }  
    }
}
