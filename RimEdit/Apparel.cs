using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
    class Apparel {
        public string Def { set; get; }
        public string Id { set; get; }
        public int Health { set; get; }
        public string Stuff { set; get; }
        public string ColorActive { set; get; }
        public string Color { set; get; }
        public string Quality { set; get; }

        public Apparel(XElement xmlApparel) {
            Def = xmlApparel.Element("def").Value;
            Id = xmlApparel.Element("id").Value;
            Health = int.Parse(xmlApparel.Element("health").Value);
            try {
                Stuff = xmlApparel.Element("stuff").Value;
            }
            catch (NullReferenceException) {
                Stuff = "";
            }
            try {
                Color = xmlApparel.Element("color").Value;
                ColorActive = "True";
            }
            catch (NullReferenceException) {
                Color = "";
                ColorActive = "False";
            }                
            Quality = xmlApparel.Element("quality").Value;
        }



    }
}
