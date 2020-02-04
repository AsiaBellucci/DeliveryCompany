using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DeliveryCompany.Classes
{
	[XmlRoot(ElementName = "Container")]
	public class Container
	{
		[XmlElement(ElementName = "Id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "ShippingDate")]
		public string ShippingDate { get; set; }
		[XmlElement(ElementName = "parcels")]
		public Parcels Parcels { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
	}
}
