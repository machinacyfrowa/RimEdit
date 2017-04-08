using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RimEdit {
        class Pawn {
        private XElement xmlPawn;
        public string Id { set; get; }
        int[] pos = new int[3];
        public string Faction { set; get; }
        public string Gender { set; get; }
        string FirstName { set; get; }
        string NickName { set; get; }
        string LastName { set; get; }
        public string FullName {
            get { return FirstName + " \"" + NickName + "\" " + LastName; }
        }
        public List<Skill> skillList = new List<Skill>();
        public List<Apparel> apparelList = new List<Apparel>();
        //public IDictionary<string, int> skillList = new Dictionary<string, int>();


        public string getXML() {
            return xmlPawn.ToString();
        }
        public Pawn() {
            Id = "";
            //pos = [0, 0, 0];
            Faction = "";
            FirstName = "";
            NickName = "";
            LastName = "";
        }
        public Pawn(XElement _xmlPawn) {
            xmlPawn = _xmlPawn;
            Id = xmlPawn.Element("id").Value;
            Faction = xmlPawn.Element("faction").Value;
            Gender = xmlPawn.Element("gender").Value;
            FirstName = xmlPawn.Element("name").Element("first").Value;
            NickName = xmlPawn.Element("name").Element("nick").Value;
            LastName = xmlPawn.Element("name").Element("last").Value;
            IEnumerable<XElement> xmlApparel = xmlPawn.Element("apparel").Element("wornApparel").Elements();
            foreach (XElement xmlItem in xmlApparel)
                apparelList.Add(new Apparel(xmlItem));
            IEnumerable<XElement> xmlSkills = xmlPawn.Element("skills").Element("skills").Elements();
            foreach (XElement xmlSkill in xmlSkills)
                skillList.Add(new Skill(xmlSkill));
            //IEnumerable<XElement> xmlSkills = xmlPawn.Element("skills").Element("skills").Elements();
            //foreach (XElement xmlSkill in xmlSkills)
            //    //TODO: check if the pawn can actually train this skill or is it blocked (using -1 for now)
            //    try {
            //        skillList.Add(xmlSkill.Element("def").Value, Int32.Parse(xmlSkill.Element("level").Value));
            //    } catch (NullReferenceException) {
            //        skillList.Add(xmlSkill.Element("def").Value, -1);
            //    }   
        }
        //public void setSkillLevel(string skillName, int skillLevel) {
        //    skillList[skillName] = skillLevel;
        //    XElement xmlSkill = xmlPawn.Element("skills").Element("skills").Elements("li")
        //                                .Where(skill => skill.Element("def").Value == skillName)
        //                                .SingleOrDefault().Parent;
            
        //}
    }
    
}
