using System.Xml.Linq;

namespace Novacode
{
    public class DTable
    {
        internal XElement Xml { get; private set; }
        internal DTable()
        {
            Xml = new XElement(
                XName.Get("dTable", DocX.c.NamespaceName),
                new XElement(XName.Get("showHorzBorder", DocX.c.NamespaceName), new XAttribute("val", "1")),
                new XElement(XName.Get("showVertBorder", DocX.c.NamespaceName), new XAttribute("val", "1")),
                new XElement(XName.Get("showOutline", DocX.c.NamespaceName), new XAttribute("val", "1")),
                new XElement(XName.Get("showKeys", DocX.c.NamespaceName), new XAttribute("val", "1"))
           
            );
        }
    }
}