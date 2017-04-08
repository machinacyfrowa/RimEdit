using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RimEdit {
    public partial class Form1 : Form {
        XElement xmlSave;
        Pawn p;
        IEnumerable<XElement> pawnList;

        public Form1() {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "%userprofile%\\appdata\\locallow\\Ludeon Studios\\RimWorld by Ludeon Studios\\Saves";
            openFileDialog1.Filter = "Rimworld XML Save (*.rws)|*.rws|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    if ((myStream = openFileDialog1.OpenFile()) != null) {
                        using (myStream) {
                            xmlSave = XElement.Load(myStream);
                            //szukaj postaci w sejwie
                            pawnList =
                                from el in xmlSave.Descendants("thing")
                                where (string)el.Attribute("Class") == "Pawn" && (string)el.Element("kindDef").Value == "Colonist"
                                select el;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                richTextBox1.Text = "znalazłem " + pawnList.Count() + "postaci";
                foreach (XElement el in pawnList)
                    p = new Pawn(el);
                loadPawnIntoFields(p);
            }
        }
        private void loadPawnIntoFields(Pawn p) {
            pawnId.Text = p.Id;
            pawnFaction.Text = p.Faction;
            pawnGender.Text = p.Gender;
            fullName.Text = p.FullName;
            //if (p.skillList["Shooting"] >= 0) {
            //    shootingUpDown.Value = p.skillList["Shooting"];
            //    shootingUpDown.Enabled = true;
            //} else {
            //    shootingUpDown.Value = 0;
            //    shootingUpDown.Enabled = false;
            //}
            //if (p.skillList["Melee"] >= 0) {
            //    meleeUpDown.Value = p.skillList["Melee"];
            //    meleeUpDown.Enabled = true;
            //} else {
            //    meleeUpDown.Value = 0;
            //    meleeUpDown.Enabled = false;
            //}
            //if (p.skillList["Social"] >= 0) {
            //    socialUpDown.Value = p.skillList["Social"];
            //    socialUpDown.Enabled = true;
            //} else {
            //    socialUpDown.Value = 0;
            //    socialUpDown.Enabled = false;
            //}
            //if(p.skillList["Animals"] >= 0) {
            //    animalUpDown.Value = p.skillList["Animals"];
            //    animalUpDown.Enabled = true;
            //} else {
            //    animalUpDown.Value = 0;
            //    animalUpDown.Enabled = false;
            //}
            //if (p.skillList["Medicine"] >= 0) {
            //    medicineUpDown.Value = p.skillList["Medicine"];
            //    medicineUpDown.Enabled = true;
            //} else {
            //    medicineUpDown.Value = 0;
            //    medicineUpDown.Enabled = false;
            //}
            //if (p.skillList["Cooking"] >= 0) {
            //    cookingUpDown.Value = p.skillList["Cooking"];
            //    cookingUpDown.Enabled = true;
            //} else {
            //    cookingUpDown.Value = 0;
            //    cookingUpDown.Enabled = false;
            //}
        }

        private void pawnToLogToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Text = p.getXML();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            //p.setSkillLevel("Shooting", 20);
        }
    }
}
