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
        private int activePawnIndex = 0;

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
            //skills
            int row = 0;
            skillsLayoutPanel.RowCount = 0;
            skillsLayoutPanel.ColumnCount = 5;
            foreach(Skill s in p.skillList) {
                skillsLayoutPanel.Controls.Add(new Label() { Text = s.Def, Anchor = AnchorStyles.Left, AutoSize = true }, 0, row);
                skillsLayoutPanel.Controls.Add(new NumericUpDown() { Name = s.Def + "UpDown", Value = s.Level}, 1, row);
                string[] passion = { "", "Minor", "Major" };
                skillsLayoutPanel.Controls.Add(new ComboBox() { Name = s.Def + "ComboBox", DataSource = passion }, 2, row);
                Button revertButton = new Button() { Name = s.Def + "RevertButton", Text = "Przywróć" };
                skillsLayoutPanel.Controls.Add(revertButton, 3, row);

                Button saveButton = new Button() { Name = s.Def + "SaveButton", Text = "Zapisz" };
                saveButton.Click += new EventHandler(skillSaveButtonClick);
                skillsLayoutPanel.Controls.Add(saveButton, 4, row);
                row++;
            }
            //gear

            
        }
        private void skillSaveButtonClick(object sender, EventArgs e) {
            Button btn = (Button)sender;
            string name = btn.Name.Remove(btn.Name.Length - 10)+"UpDown";
            NumericUpDown upDown = (NumericUpDown)skillsLayoutPanel.Controls.Find(name,true).FirstOrDefault();
            int row = skillsLayoutPanel.GetRow(btn);
            pawnList[activePawnIndex].skillList[row].Level = (int)upDown.Value;
        }
        private void skillRevertButton(object sender, EventArgs e) {
            Button btn = (Button)sender;
            string name = btn.Name.Remove(btn.Name.Length - 12) + "UpDown";
            NumericUpDown upDown = (NumericUpDown)skillsLayoutPanel.Controls.Find(name, true).FirstOrDefault();
            int row = skillsLayoutPanel.GetRow(btn);
            upDown.Value = pawnList[activePawnIndex].skillList[row].Level;
        }
        private void pawnToLogToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Text = pawnList.First().getXML();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            xmlSave.Save(fileName);
        }
    }
}
