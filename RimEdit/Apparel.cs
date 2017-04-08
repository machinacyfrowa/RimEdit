using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
    class Apparel {
        private XElement xml;
        public string Def {
            set {
                xml.Element("def").Value = value;
            }
            get {
                return xml.Element("def").Value;
            }
        }
        public string Id {
            set {
                xml.Element("id").Value = value;
            }
            get {
                return xml.Element("id").Value;
            }
        }
        public int Health {
            set {
                xml.Element("health").Value = value.ToString();
            }
            get {
                return Int32.Parse(xml.Element("health").Value);
            }
        }
        public string Stuff {
            set {
                if (String.IsNullOrEmpty(value))
                    xml.Element("stuff").Value = value;
            }
            get {
                try {
                    return xml.Element("stuff").Value;
                } catch (Exception) {
                    return "";
                }
            }
        }
        public string Color {
            set {
                if (String.IsNullOrEmpty(value))
                    xml.Element("color").Value = value;
            }
            get {
                try {
                    return xml.Element("color").Value;
                } catch (Exception) {
                    return "";
                }
            }
        }
        public string Quality {
            set {
                if (String.IsNullOrEmpty(value))
                    xml.Element("quality").Value = value;
            }
            get {
                try {
                    return xml.Element("quality").Value;
                } catch (Exception) {
                    return "";
                }
            }
        }

        public Apparel(XElement _xml) {
            xml = _xml;               
        }



    }
}
