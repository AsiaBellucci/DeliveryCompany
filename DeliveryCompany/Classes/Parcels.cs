using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DeliveryCompany.Classes
{
	[XmlRoot(ElementName = "parcels")]
	public class Parcels
	{
		[XmlElement(ElementName = "Parcel")]
		public List<Parcel> Parcel { get; set; }
	}
}
