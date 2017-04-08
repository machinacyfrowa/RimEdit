using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
    class Skill {
        private XElement xml;
        private string Def {
            set {
                xml.Element("def").Value = value;
            }
            get {
                return xml.Element("def").Value;
            }
        }
        private int Level {
            set {
                xml.Element("level").Value = value.ToString();
            }
            get {
                return Int32.Parse(xml.Element("level").Value);
            }
        }
        private float XpSinceLastLevel {
            set {
                xml.Element("xpSinceLastLevel").Value = value.ToString();
            }
            get {
                return float.Parse(xml.Element("xpSinceLastLevel").Value,
                                    System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        private string Passion;
        private float XpSinceMidnight;

        public Skill(XElement _xml) {
            xml = _xml;
        }
    }
}
