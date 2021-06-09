using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using static JewelryStore.Dal.Customer;

namespace JewelryStore.Dal
{
    public class CustomerData
    {
        private CustomerList customres;
        public CustomerData()
        {
            customres = LoadData();
        }

        public Customer GetCustomerData(string userName, string Password)
        {
            try
            {
                return customres?.Customers.Single(x => x.UserName == userName && x.Password == Password);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        private CustomerList LoadData()
        {
            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = buildDir + Resource.DataFileLocation;
            try
            {
                using (TextReader reader = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(CustomerList));
                    return (CustomerList)serializer.Deserialize(reader);
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}