using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DeliveryCompany.Classes
{
	[XmlRoot(ElementName = "Sender")]
	public class Sender
    {
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Address")]
		public Address Address { get; set; }
		[XmlElement(ElementName = "CcNumber")]
		public string CcNumber { get; set; }
		[XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Type { get; set; }
	}
}
