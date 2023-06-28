using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

class Test
{
    static void Main()
    {
        XmlSerializer ser = new XmlSerializer(typeof(PurchaseOrder));
        TextWriter writer = new StringWriter();
        ser.Serialize(writer, new PurchaseOrder()
        {
            MyAddress = new Address() { FirstName = "Andrii" }
        });
        Console.WriteLine(writer.ToString());
    }
}

public class PurchaseOrder
{
    public Address MyAddress;
}

public class Address
{
    public string FirstName;
}
