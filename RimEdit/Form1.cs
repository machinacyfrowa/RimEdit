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
        public XElement xmlSave;
        private string fileName;
        private List<Pawn> pawnList = new List<Pawn>();

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
                fileName = openFileDialog1.FileName;
                try {
                    if ((myStream = openFileDialog1.OpenFile()) != null) {
                        using (myStream) {
                            xmlSave = XElement.Load(myStream);
                            //szukaj postaci w sejwie
                            IEnumerable<XElement> pawns =
                                from el in xmlSave.Descendants("thing")
                                where (string)el.Attribute("Class") == "Pawn" && (string)el.Element("kindDef").Value == "Colonist"
                                select el;
                            foreach (XElement pawnXml in pawns)
                                pawnList.Add(new Pawn(pawnXml));
                            Text = "RimEdit " + fileName;
                        }
                        myStream.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                richTextBox1.Text = "znalazłem " + pawnList.Count() + "postaci";
                loadPawnIntoFields(pawnList.First());
            }
        }
        private void loadPawnIntoFields(Pawn p) {
            pawnId.Text = p.Id;
            pawnFaction.Text = p.Faction;
            pawnGender.Text = p.Gender;
            fullName.Text = p.FullName;
            p.setSkill(0, 20);
        }

        private void pawnToLogToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Text = pawnList.First().getXML();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            xmlSave.Save(fileName);
        }
    }
}
