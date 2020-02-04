using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DeliveryCompany.Classes
{
	[XmlRoot(ElementName = "Parcel")]
	public class Parcel
	{
		[XmlElement(ElementName = "Sender")]
		public Sender Sender { get; set; }
		[XmlElement(ElementName = "Receipient")]
		public Receipient Receipient { get; set; }
		[XmlElement(ElementName = "Weight")]
		public string Weight { get; set; }
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
	}
}
