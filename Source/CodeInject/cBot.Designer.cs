﻿namespace CodeInject
{
    partial class cBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bRemoveMonster2Attack = new System.Windows.Forms.Button();
            this.bAddMonster2Attack = new System.Windows.Forms.Button();
            this.lMonster2Attack = new System.Windows.Forms.ListBox();
            this.lFullMonsterList = new System.Windows.Forms.ListBox();
            this.bHuntToggle = new System.Windows.Forms.Button();
            this.tSearchMobTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lNPClist = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSkillRemove = new System.Windows.Forms.Button();
            this.bSkillAdd = new System.Windows.Forms.Button();
            this.lUseSkill = new System.Windows.Forms.ListBox();
            this.bSkillRefresh = new System.Windows.Forms.Button();
            this.lSkillList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tPickupRadius = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lNearItemsList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pickUpTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cEnableHuntingArea = new System.Windows.Forms.CheckBox();
            this.tXHuntArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tYHuntArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tHuntRadius = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bSetArea = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tZHuntArea = new System.Windows.Forms.TextBox();
            this.cPickupnOnlyHuntArea = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bRemoveMonster2Attack);
            this.tabPage1.Controls.Add(this.bAddMonster2Attack);
            this.tabPage1.Controls.Add(this.lMonster2Attack);
            this.tabPage1.Controls.Add(this.lFullMonsterList);
            this.tabPage1.Controls.Add(this.bHuntToggle);
            this.tabPage1.Controls.Add(this.tSearchMobTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hunt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // bRemoveMonster2Attack
            // 
            this.bRemoveMonster2Attack.Location = new System.Drawing.Point(359, 168);
            this.bRemoveMonster2Attack.Name = "bRemoveMonster2Attack";
            this.bRemoveMonster2Attack.Size = new System.Drawing.Size(75, 23);
            this.bRemoveMonster2Attack.TabIndex = 6;
            this.bRemoveMonster2Attack.Text = "Remove";
            this.bRemoveMonster2Attack.UseVisualStyleBackColor = true;
            this.bRemoveMonster2Attack.Click += new System.EventHandler(this.bRemoveMonster2Attack_Click);
            // 
            // bAddMonster2Attack
            // 
            this.bAddMonster2Attack.Location = new System.Drawing.Point(235, 168);
            this.bAddMonster2Attack.Name = "bAddMonster2Attack";
            this.bAddMonster2Attack.Size = new System.Drawing.Size(75, 23);
            this.bAddMonster2Attack.TabIndex = 5;
            this.bAddMonster2Attack.Text = "Add";
            this.bAddMonster2Attack.UseVisualStyleBackColor = true;
            this.bAddMonster2Attack.Click += new System.EventHandler(this.bAddMonster2Attack_Click);
            // 
            // lMonster2Attack
            // 
            this.lMonster2Attack.FormattingEnabled = true;
            this.lMonster2Attack.Location = new System.Drawing.Point(215, 198);
            this.lMonster2Attack.Name = "lMonster2Attack";
            this.lMonster2Attack.Size = new System.Drawing.Size(257, 147);
            this.lMonster2Attack.TabIndex = 4;
            // 
            // lFullMonsterList
            // 
            this.lFullMonsterList.FormattingEnabled = true;
            this.lFullMonsterList.Location = new System.Drawing.Point(215, 67);
            this.lFullMonsterList.Name = "lFullMonsterList";
            this.lFullMonsterList.Size = new System.Drawing.Size(257, 95);
            this.lFullMonsterList.TabIndex = 3;
            // 
            // bHuntToggle
            // 
            this.bHuntToggle.Location = new System.Drawing.Point(375, 12);
            this.bHuntToggle.Name = "bHuntToggle";
            this.bHuntToggle.Size = new System.Drawing.Size(103, 23);
            this.bHuntToggle.TabIndex = 1;
            this.bHuntToggle.Text = "Start";
            this.bHuntToggle.UseVisualStyleBackColor = true;
            this.bHuntToggle.Click += new System.EventHandler(this.bHuntToggle_Click);
            // 
            // tSearchMobTextBox
            // 
            this.tSearchMobTextBox.Location = new System.Drawing.Point(215, 41);
            this.tSearchMobTextBox.Name = "tSearchMobTextBox";
            this.tSearchMobTextBox.Size = new System.Drawing.Size(257, 20);
            this.tSearchMobTextBox.TabIndex = 2;
            this.tSearchMobTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search monster:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lNPClist);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPC List";
            // 
            // lNPClist
            // 
            this.lNPClist.FormattingEnabled = true;
            this.lNPClist.Location = new System.Drawing.Point(6, 19);
            this.lNPClist.Name = "lNPClist";
            this.lNPClist.Size = new System.Drawing.Size(188, 446);
            this.lNPClist.TabIndex = 1;
            this.lNPClist.SelectedIndexChanged += new System.EventHandler(this.lNPClist_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSkillRemove);
            this.tabPage2.Controls.Add(this.bSkillAdd);
            this.tabPage2.Controls.Add(this.lUseSkill);
            this.tabPage2.Controls.Add(this.bSkillRefresh);
            this.tabPage2.Controls.Add(this.lSkillList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skill";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSkillRemove
            // 
            this.bSkillRemove.Location = new System.Drawing.Point(132, 84);
            this.bSkillRemove.Name = "bSkillRemove";
            this.bSkillRemove.Size = new System.Drawing.Size(42, 23);
            this.bSkillRemove.TabIndex = 6;
            this.bSkillRemove.Text = "<";
            this.bSkillRemove.UseVisualStyleBackColor = true;
            this.bSkillRemove.Click += new System.EventHandler(this.bSkillRemove_Click);
            // 
            // bSkillAdd
            // 
            this.bSkillAdd.Location = new System.Drawing.Point(132, 55);
            this.bSkillAdd.Name = "bSkillAdd";
            this.bSkillAdd.Size = new System.Drawing.Size(42, 23);
            this.bSkillAdd.TabIndex = 5;
            this.bSkillAdd.Text = ">";
            this.bSkillAdd.UseVisualStyleBackColor = true;
            this.bSkillAdd.Click += new System.EventHandler(this.bSkillAdd_Click);
            // 
            // lUseSkill
            // 
            this.lUseSkill.FormattingEnabled = true;
            this.lUseSkill.Location = new System.Drawing.Point(180, 6);
            this.lUseSkill.Name = "lUseSkill";
            this.lUseSkill.Size = new System.Drawing.Size(120, 134);
            this.lUseSkill.TabIndex = 4;
            // 
            // bSkillRefresh
            // 
            this.bSkillRefresh.Location = new System.Drawing.Point(6, 146);
            this.bSkillRefresh.Name = "bSkillRefresh";
            this.bSkillRefresh.Size = new System.Drawing.Size(120, 23);
            this.bSkillRefresh.TabIndex = 3;
            this.bSkillRefresh.Text = "Refresh";
            this.bSkillRefresh.UseVisualStyleBackColor = true;
            this.bSkillRefresh.Click += new System.EventHandler(this.bSkillRefresh_Click);
            // 
            // lSkillList
            // 
            this.lSkillList.FormattingEnabled = true;
            this.lSkillList.Location = new System.Drawing.Point(6, 6);
            this.lSkillList.Name = "lSkillList";
            this.lSkillList.Size = new System.Drawing.Size(120, 134);
            this.lSkillList.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cPickupnOnlyHuntArea);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tPickupRadius);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(490, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pick UP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick up radius";
            // 
            // tPickupRadius
            // 
            this.tPickupRadius.Location = new System.Drawing.Point(212, 53);
            this.tPickupRadius.Name = "tPickupRadius";
            this.tPickupRadius.Size = new System.Drawing.Size(100, 20);
            this.tPickupRadius.TabIndex = 4;
            this.tPickupRadius.Text = "10,0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lNearItemsList);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 474);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Near items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lNearItemsList
            // 
            this.lNearItemsList.FormattingEnabled = true;
            this.lNearItemsList.Location = new System.Drawing.Point(6, 19);
            this.lNearItemsList.Name = "lNearItemsList";
            this.lNearItemsList.Size = new System.Drawing.Size(188, 407);
            this.lNearItemsList.TabIndex = 2;
            this.lNearItemsList.SelectedIndexChanged += new System.EventHandler(this.lNearItemsList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pickUpTimer
            // 
            this.pickUpTimer.Interval = 150;
            this.pickUpTimer.Tick += new System.EventHandler(this.pickUpTimer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tZHuntArea);
            this.groupBox3.Controls.Add(this.bSetArea);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tHuntRadius);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tYHuntArea);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tXHuntArea);
            this.groupBox3.Controls.Add(this.cEnableHuntingArea);
            this.groupBox3.Location = new System.Drawing.Point(215, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 135);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hunting Area";
            // 
            // cEnableHuntingArea
            // 
            this.cEnableHuntingArea.AutoSize = true;
            this.cEnableHuntingArea.Location = new System.Drawing.Point(6, 19);
            this.cEnableHuntingArea.Name = "cEnableHuntingArea";
            this.cEnableHuntingArea.Size = new System.Drawing.Size(104, 17);
            this.cEnableHuntingArea.TabIndex = 0;
            this.cEnableHuntingArea.Text = "Set hunting area";
            this.cEnableHuntingArea.UseVisualStyleBackColor = true;
            // 
            // tXHuntArea
            // 
            this.tXHuntArea.Location = new System.Drawing.Point(144, 19);
            this.tXHuntArea.Name = "tXHuntArea";
            this.tXHuntArea.Size = new System.Drawing.Size(100, 20);
            this.tXHuntArea.TabIndex = 1;
            this.tXHuntArea.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // tYHuntArea
            // 
            this.tYHuntArea.Location = new System.Drawing.Point(144, 45);
            this.tYHuntArea.Name = "tYHuntArea";
            this.tYHuntArea.Size = new System.Drawing.Size(100, 20);
            this.tYHuntArea.TabIndex = 3;
            this.tYHuntArea.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y:";
            // 
            // tHuntRadius
            // 
            this.tHuntRadius.Location = new System.Drawing.Point(10, 64);
            this.tHuntRadius.Name = "tHuntRadius";
            this.tHuntRadius.Size = new System.Drawing.Size(100, 20);
            this.tHuntRadius.TabIndex = 5;
            this.tHuntRadius.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Radius: ";
            // 
            // bSetArea
            // 
            this.bSetArea.Location = new System.Drawing.Point(10, 106);
            this.bSetArea.Name = "bSetArea";
            this.bSetArea.Size = new System.Drawing.Size(234, 23);
            this.bSetArea.TabIndex = 7;
            this.bSetArea.Text = "Set";
            this.bSetArea.UseVisualStyleBackColor = true;
            this.bSetArea.Click += new System.EventHandler(this.bSetArea_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Z:";
            // 
            // tZHuntArea
            // 
            this.tZHuntArea.Location = new System.Drawing.Point(144, 71);
            this.tZHuntArea.Name = "tZHuntArea";
            this.tZHuntArea.Size = new System.Drawing.Size(100, 20);
            this.tZHuntArea.TabIndex = 8;
            this.tZHuntArea.Text = "1";
            // 
            // cPickupnOnlyHuntArea
            // 
            this.cPickupnOnlyHuntArea.AutoSize = true;
            this.cPickupnOnlyHuntArea.Location = new System.Drawing.Point(215, 17);
            this.cPickupnOnlyHuntArea.Name = "cPickupnOnlyHuntArea";
            this.cPickupnOnlyHuntArea.Size = new System.Drawing.Size(148, 17);
            this.cPickupnOnlyHuntArea.TabIndex = 6;
            this.cPickupnOnlyHuntArea.Text = "Pick up only in Hunt area:";
            this.cPickupnOnlyHuntArea.UseVisualStyleBackColor = true;
            // 
            // cBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 522);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "cBot";
            this.Text = "cBot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lNPClist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSkillRefresh;
        private System.Windows.Forms.ListBox lSkillList;
        private System.Windows.Forms.ListBox lUseSkill;
        private System.Windows.Forms.Button bSkillRemove;
        private System.Windows.Forms.Button bSkillAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSearchMobTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bHuntToggle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Timer pickUpTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lNearItemsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tPickupRadius;
        private System.Windows.Forms.ListBox lFullMonsterList;
        private System.Windows.Forms.Button bAddMonster2Attack;
        private System.Windows.Forms.ListBox lMonster2Attack;
        private System.Windows.Forms.Button bRemoveMonster2Attack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tYHuntArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tXHuntArea;
        private System.Windows.Forms.CheckBox cEnableHuntingArea;
        private System.Windows.Forms.Button bSetArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tHuntRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tZHuntArea;
        private System.Windows.Forms.CheckBox cPickupnOnlyHuntArea;
    }
}