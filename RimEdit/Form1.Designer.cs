namespace RimEdit {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pawnId = new System.Windows.Forms.TextBox();
            this.pawnFaction = new System.Windows.Forms.TextBox();
            this.pawnGender = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.researchUpDown = new System.Windows.Forms.NumericUpDown();
            this.craftingUpDown = new System.Windows.Forms.NumericUpDown();
            this.artisticUpDown = new System.Windows.Forms.NumericUpDown();
            this.miningUpDown = new System.Windows.Forms.NumericUpDown();
            this.growingUpDown = new System.Windows.Forms.NumericUpDown();
            this.constructionUpDown = new System.Windows.Forms.NumericUpDown();
            this.cookingUpDown = new System.Windows.Forms.NumericUpDown();
            this.medicineUpDown = new System.Windows.Forms.NumericUpDown();
            this.animalUpDown = new System.Windows.Forms.NumericUpDown();
            this.socialUpDown = new System.Windows.Forms.NumericUpDown();
            this.meleeUpDown = new System.Windows.Forms.NumericUpDown();
            this.shootingUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fullName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pawnToLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.craftingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artisticUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miningUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meleeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 442);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(997, 122);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "test";
            // 
            // pawnId
            // 
            this.pawnId.Location = new System.Drawing.Point(63, 6);
            this.pawnId.Name = "pawnId";
            this.pawnId.Size = new System.Drawing.Size(100, 20);
            this.pawnId.TabIndex = 2;
            // 
            // pawnFaction
            // 
            this.pawnFaction.Location = new System.Drawing.Point(63, 32);
            this.pawnFaction.Name = "pawnFaction";
            this.pawnFaction.Size = new System.Drawing.Size(100, 20);
            this.pawnFaction.TabIndex = 3;
            // 
            // pawnGender
            // 
            this.pawnGender.Location = new System.Drawing.Point(63, 58);
            this.pawnGender.Name = "pawnGender";
            this.pawnGender.Size = new System.Drawing.Size(100, 20);
            this.pawnGender.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 382);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pawnId);
            this.tabPage1.Controls.Add(this.pawnGender);
            this.tabPage1.Controls.Add(this.pawnFaction);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faction:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.researchUpDown);
            this.tabPage2.Controls.Add(this.craftingUpDown);
            this.tabPage2.Controls.Add(this.artisticUpDown);
            this.tabPage2.Controls.Add(this.miningUpDown);
            this.tabPage2.Controls.Add(this.growingUpDown);
            this.tabPage2.Controls.Add(this.constructionUpDown);
            this.tabPage2.Controls.Add(this.cookingUpDown);
            this.tabPage2.Controls.Add(this.medicineUpDown);
            this.tabPage2.Controls.Add(this.animalUpDown);
            this.tabPage2.Controls.Add(this.socialUpDown);
            this.tabPage2.Controls.Add(this.meleeUpDown);
            this.tabPage2.Controls.Add(this.shootingUpDown);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skills";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // researchUpDown
            // 
            this.researchUpDown.Location = new System.Drawing.Point(535, 294);
            this.researchUpDown.Name = "researchUpDown";
            this.researchUpDown.Size = new System.Drawing.Size(40, 20);
            this.researchUpDown.TabIndex = 18;
            // 
            // craftingUpDown
            // 
            this.craftingUpDown.Location = new System.Drawing.Point(535, 268);
            this.craftingUpDown.Name = "craftingUpDown";
            this.craftingUpDown.Size = new System.Drawing.Size(40, 20);
            this.craftingUpDown.TabIndex = 17;
            // 
            // artisticUpDown
            // 
            this.artisticUpDown.Location = new System.Drawing.Point(535, 242);
            this.artisticUpDown.Name = "artisticUpDown";
            this.artisticUpDown.Size = new System.Drawing.Size(40, 20);
            this.artisticUpDown.TabIndex = 16;
            // 
            // miningUpDown
            // 
            this.miningUpDown.Location = new System.Drawing.Point(535, 216);
            this.miningUpDown.Name = "miningUpDown";
            this.miningUpDown.Size = new System.Drawing.Size(40, 20);
            this.miningUpDown.TabIndex = 15;
            // 
            // growingUpDown
            // 
            this.growingUpDown.Location = new System.Drawing.Point(535, 190);
            this.growingUpDown.Name = "growingUpDown";
            this.growingUpDown.Size = new System.Drawing.Size(40, 20);
            this.growingUpDown.TabIndex = 14;
            // 
            // constructionUpDown
            // 
            this.constructionUpDown.Location = new System.Drawing.Point(535, 164);
            this.constructionUpDown.Name = "constructionUpDown";
            this.constructionUpDown.Size = new System.Drawing.Size(40, 20);
            this.constructionUpDown.TabIndex = 13;
            // 
            // cookingUpDown
            // 
            this.cookingUpDown.Location = new System.Drawing.Point(535, 138);
            this.cookingUpDown.Name = "cookingUpDown";
            this.cookingUpDown.Size = new System.Drawing.Size(40, 20);
            this.cookingUpDown.TabIndex = 12;
            // 
            // medicineUpDown
            // 
            this.medicineUpDown.Location = new System.Drawing.Point(535, 112);
            this.medicineUpDown.Name = "medicineUpDown";
            this.medicineUpDown.Size = new System.Drawing.Size(40, 20);
            this.medicineUpDown.TabIndex = 11;
            // 
            // animalUpDown
            // 
            this.animalUpDown.Location = new System.Drawing.Point(535, 86);
            this.animalUpDown.Name = "animalUpDown";
            this.animalUpDown.Size = new System.Drawing.Size(40, 20);
            this.animalUpDown.TabIndex = 10;
            // 
            // socialUpDown
            // 
            this.socialUpDown.Location = new System.Drawing.Point(535, 60);
            this.socialUpDown.Name = "socialUpDown";
            this.socialUpDown.Size = new System.Drawing.Size(40, 20);
            this.socialUpDown.TabIndex = 9;
            // 
            // meleeUpDown
            // 
            this.meleeUpDown.Location = new System.Drawing.Point(535, 34);
            this.meleeUpDown.Name = "meleeUpDown";
            this.meleeUpDown.Size = new System.Drawing.Size(40, 20);
            this.meleeUpDown.TabIndex = 8;
            // 
            // shootingUpDown
            // 
            this.shootingUpDown.Location = new System.Drawing.Point(535, 8);
            this.shootingUpDown.Name = "shootingUpDown";
            this.shootingUpDown.Size = new System.Drawing.Size(40, 20);
            this.shootingUpDown.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Melee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Shooting";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(989, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullName.Location = new System.Drawing.Point(386, 26);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(243, 25);
            this.fullName.TabIndex = 6;
            this.fullName.Text = "Imie \"Ksywka\" Nazwisko";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "< Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Next >";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Medicine";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pawnToLogToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // pawnToLogToolStripMenuItem
            // 
            this.pawnToLogToolStripMenuItem.Name = "pawnToLogToolStripMenuItem";
            this.pawnToLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pawnToLogToolStripMenuItem.Text = "Pawn to log";
            this.pawnToLogToolStripMenuItem.Click += new System.EventHandler(this.pawnToLogToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.craftingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artisticUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miningUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.growingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meleeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox pawnId;
        private System.Windows.Forms.TextBox pawnFaction;
        private System.Windows.Forms.TextBox pawnGender;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown socialUpDown;
        private System.Windows.Forms.NumericUpDown meleeUpDown;
        private System.Windows.Forms.NumericUpDown shootingUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown animalUpDown;
        private System.Windows.Forms.NumericUpDown researchUpDown;
        private System.Windows.Forms.NumericUpDown craftingUpDown;
        private System.Windows.Forms.NumericUpDown artisticUpDown;
        private System.Windows.Forms.NumericUpDown miningUpDown;
        private System.Windows.Forms.NumericUpDown growingUpDown;
        private System.Windows.Forms.NumericUpDown constructionUpDown;
        private System.Windows.Forms.NumericUpDown cookingUpDown;
        private System.Windows.Forms.NumericUpDown medicineUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pawnToLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

