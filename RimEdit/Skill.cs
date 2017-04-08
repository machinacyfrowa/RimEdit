using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
    class Skill {
        private XElement xml;
        public string Def {
            set {
                xml.Element("def").Value = value;
            }
            get {
                return xml.Element("def").Value;
            }
        }
        public int Level {
            set {
                xml.Element("level").Value = value.ToString();
            }
            get {
                return Int32.Parse(xml.Element("level").Value);
            }
        }
        public float XpSinceLastLevel {
            set {
                xml.Element("xpSinceLastLevel").Value = value.ToString();
            }
            get {
                return float.Parse(xml.Element("xpSinceLastLevel").Value,
                                    System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        public string Passion {
            set {
                if (String.IsNullOrEmpty(value))
                    xml.Element("passion").Value = value;
            }
            get {
                try {
                    return xml.Element("passion").Value;
                } catch (Exception) {
                    return "";
                }
            }
        }
        public float XpSinceMidnight {
            set {
                if(value > 0) {
                    xml.Element("xpSinceMidnight").Value = value.ToString();
                }
            }
            get {
                try {
                    return float.Parse(xml.Element("xpSinceMidnight").Value, 
                                System.Globalization.CultureInfo.InvariantCulture);
                } catch (Exception) {
                    return 0;
                }
            }
        }

        public Skill(XElement _xml) {
            xml = _xml;
        }
    }
}
