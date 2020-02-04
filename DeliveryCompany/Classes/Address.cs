using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DeliveryCompany
{
	[XmlRoot(ElementName = "Address")]
	public class Address
    {
		[XmlElement(ElementName = "Street")]
		public string Street { get; set; }
		[XmlElement(ElementName = "HouseNumber")]
		public string HouseNumber { get; set; }
		[XmlElement(ElementName = "PostalCode")]
		public string PostalCode { get; set; }
		[XmlElement(ElementName = "City")]
		public string City { get; set; }
	}
}
