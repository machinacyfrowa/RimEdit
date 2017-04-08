using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
        class Pawn {
        public XElement xml;
        public string Id {
            set {
                xml.Element("id").Value = value;
            }
            get {
                return xml.Element("id").Value;
            }
        }
        public string Faction {
            set {
                xml.Element("faction").Value = value;
            }
            get {
                return xml.Element("faction").Value;
            }
        }
        public string Gender {
            set {
                xml.Element("gender").Value = value;
            }
            get {
                return xml.Element("gender").Value;
            }
        }
        public string FirstName {
            set {
                xml.Element("name").Element("first").Value = value;
            }
            get {
                return xml.Element("name").Element("first").Value;
            }
        }
        public string NickName {
            set {
                xml.Element("name").Element("nick").Value = value;
            }
            get {
                return xml.Element("name").Element("nick").Value;
            }
        }
        string LastName {
            set {
                xml.Element("name").Element("last").Value = value;
            }
            get {
                return xml.Element("name").Element("last").Value;
            }
        }
        public string FullName {
            get { return FirstName + " \"" + NickName + "\" " + LastName; }
        }
        private List<Skill> skillList = new List<Skill>();
        private List<Apparel> apparelList = new List<Apparel>();

        
        public Pawn(XElement _xml) {
            xml = _xml;
            foreach (XElement xmlItem in xml.Element("apparel").Element("wornApparel").Elements())
                apparelList.Add(new Apparel(xmlItem));
            foreach (XElement xmlSkill in xml.Element("skills").Element("skills").Elements())
                skillList.Add(new Skill(xmlSkill)); 
        }
        public string getXML() {
            return xml.ToString();
        }
        public void setSkill(int skillIndex, int skillLevel) {
            skillList[skillIndex].Level = skillLevel;
        }
    }
    
}
