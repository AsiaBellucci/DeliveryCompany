using DeliveryCompany.Abstracts;
using DeliveryCompany.Classes;
using DeliveryCompany.Classes.Department;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;


namespace DeliveryCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("Container_1.xml");

            #region
            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element: // The node is an element.
            //            Console.Write("<" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //        case XmlNodeType.Text: //Display the text in each element.
            //            Console.WriteLine(reader.Value);
            //            break;
            //        case XmlNodeType.EndElement: //Display the end of the element.
            //            Console.Write("</" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //    }
            //}

            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element: // The node is an element.
            //            Console.Write("<" + reader.Name);

            //            while (reader.MoveToNextAttribute()) // Read the attributes.
            //                Console.Write(" " + reader.Name + "='" + reader.Value + "'");
            //            Console.WriteLine(">");
            //            break;
            //        case XmlNodeType.Text: //Display the text in each element.
            //            Console.WriteLine(reader.Value);
            //            break;
            //        case XmlNodeType.EndElement: //Display the end of the element.
            //            Console.Write("</" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //    }
            //}

            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element:
            //            Console.WriteLine(reader.Name);
            //            
            //            break;
            //        case XmlNodeType.Text:
            //            Console.WriteLine("SECONDO CASE "+ reader.Value);
            //            break;
            //    }
            //}
            #endregion

            Handler mail = new Mail();
            Handler regular = new Regular();
            Handler heavy = new Heavy();

            mail.SetNext(regular);
            regular.SetNext(heavy);



            string path = @"C:\Git\DeliveryCompany\DeliveryCompany\Container_1.xml";
            XDocument doc = XDocument.Load(path);
            string jsonText = JsonConvert.SerializeXNode(doc);

            var rootObj = JsonConvert.DeserializeObject<MyXmlObj.RootObj>(jsonText);

            

            #region --------------------FOR IF SWITCH-----------------------
            //for (int i = 0; i < 4; i++)
            //{
            //    string peso = rootObj.Container.Parcels.Parcel[i].Weight;
            //    double Peso = Convert.ToDouble(peso, new CultureInfo("en-US"));
            //    string val = rootObj.Container.Parcels.Parcel[i].Value;
            //    double Valore = Convert.ToDouble(val, new CultureInfo("en-US"));
            //    Console.WriteLine("Pacco " + i + ":---> peso: " + Peso + "   valore €: " + Valore);
            //    int X = 4;

            //    if (Valore > 1000)
            //    {
            //        X = 0;
            //    }
            //    else if (Peso < 1)
            //    {
            //        X = 1;
            //    }
            //    else if (Peso > 1 && Peso < 10)
            //    {
            //        X = 2;
            //    }
            //    else if (Peso > 10)
            //    {
            //        X = 3;
            //    }
            //    switch (X)
            //    {
            //        case 0:
            //            if (Peso < 1)
            //            {
            //                Console.WriteLine("Go to INSURANCE department and then to MAIL department");
            //            }
            //            else if (Peso > 1 && Peso < 10)
            //            {
            //                Console.WriteLine("Go to INSURANCE department and then to REGULAR department");
            //            }
            //            else if (Peso > 10)
            //            {
            //                Console.WriteLine("Go to INSURANCE department and then to HEAVY department");
            //            }
            //            break;
            //        case 1:
            //            Console.WriteLine("Go to MAIL department");
            //            break;
            //        case 2:
            //            Console.WriteLine("Go to REGULAR department");
            //            break;
            //        case 3:
            //            Console.WriteLine("Go to HEAVY department");
            //            break;
            //        case 4:
            //            Console.WriteLine("Pacco non accettato");
            //            break;
            //    }
            //}
            #endregion
            int y = rootObj.Container.Parcels.Parcel.Count;
            for(int p=0; p<y; p++)
            {
                string mittente = rootObj.Container.Parcels.Parcel[p].Sender.Name;
                string destinatario = rootObj.Container.Parcels.Parcel[p].Receipient.Name;
                double Peso = Convert.ToDouble(rootObj.Container.Parcels.Parcel[p].Weight, new CultureInfo("en-US"));
                double Valore = Convert.ToDouble(rootObj.Container.Parcels.Parcel[p].Value, new CultureInfo("en-US"));

                ParcelHandler paccoFile = new ParcelHandler(mittente, destinatario, Peso, Valore);
                mail.Handle(paccoFile);
                Console.WriteLine($"Mittente: {paccoFile.Sender} -- Destinatario: {paccoFile.Receipient}");
                Console.WriteLine("___________________________________________________________________________________________________");
                //regular.Handle(paccoFile);
                //heavy.Handle(paccoFile);
            }

        }
    }
}
