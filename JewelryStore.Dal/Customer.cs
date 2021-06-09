using System.Xml.Serialization;

namespace JewelryStore.Dal
{
    public class Customer
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CustomerType { get; set; }

    }

    [XmlRootAttribute("CustomerList")]
    public class CustomerList
    {
        [XmlElement("Customer")]
        public Customer[] Customers { get; set; }
    }
}
