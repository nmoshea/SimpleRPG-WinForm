namespace GameProject___Form
{
    partial class Form1
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
            this.MoveWest = new System.Windows.Forms.Button();
            this.MoveNorth = new System.Windows.Forms.Button();
            this.MoveEast = new System.Windows.Forms.Button();
            this.South = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Attack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PickUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentLoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.DefenceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnemyHealth = new System.Windows.Forms.Label();
            this.EnemyDefenceLabel = new System.Windows.Forms.Label();
            this.EnemyAttack = new System.Windows.Forms.Label();
            this.EnemyType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.GroupBox();
            this.TotalWeightLabel = new System.Windows.Forms.Label();
            this.TotalWeight = new System.Windows.Forms.Label();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.ArmourLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveWest
            // 
            this.MoveWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveWest.Location = new System.Drawing.Point(518, 416);
            this.MoveWest.Name = "MoveWest";
            this.MoveWest.Size = new System.Drawing.Size(75, 41);
            this.MoveWest.TabIndex = 0;
            this.MoveWest.Text = "West";
            this.MoveWest.UseVisualStyleBackColor = true;
            this.MoveWest.Click += new System.EventHandler(this.MoveWest_Click);
            // 
            // MoveNorth
            // 
            this.MoveNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveNorth.Location = new System.Drawing.Point(590, 369);
            this.MoveNorth.Name = "MoveNorth";
            this.MoveNorth.Size = new System.Drawing.Size(75, 41);
            this.MoveNorth.TabIndex = 1;
            this.MoveNorth.Text = "North";
            this.MoveNorth.UseVisualStyleBackColor = true;
            this.MoveNorth.Click += new System.EventHandler(this.MoveNorth_Click);
            // 
            // MoveEast
            // 
            this.MoveEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveEast.Location = new System.Drawing.Point(663, 416);
            this.MoveEast.Name = "MoveEast";
            this.MoveEast.Size = new System.Drawing.Size(75, 41);
            this.MoveEast.TabIndex = 2;
            this.MoveEast.Text = "East";
            this.MoveEast.UseVisualStyleBackColor = true;
            this.MoveEast.Click += new System.EventHandler(this.MoveEast_Click);
            // 
            // South
            // 
            this.South.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.South.Location = new System.Drawing.Point(590, 460);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(75, 41);
            this.South.TabIndex = 3;
            this.South.Text = "South";
            this.South.UseVisualStyleBackColor = true;
            this.South.Click += new System.EventHandler(this.South_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(785, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 278);
            this.textBox1.TabIndex = 6;
            // 
            // Attack
            // 
            this.Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack.Location = new System.Drawing.Point(13, 11);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(86, 42);
            this.Attack.TabIndex = 7;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PickUp);
            this.panel1.Controls.Add(this.Attack);
            this.panel1.Location = new System.Drawing.Point(785, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 167);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Drop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DropItem);
            // 
            // PickUp
            // 
            this.PickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUp.Location = new System.Drawing.Point(163, 11);
            this.PickUp.Name = "PickUp";
            this.PickUp.Size = new System.Drawing.Size(86, 42);
            this.PickUp.TabIndex = 8;
            this.PickUp.Text = "Pick Up";
            this.PickUp.UseVisualStyleBackColor = true;
            this.PickUp.Click += new System.EventHandler(this.PickUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Command";
            // 
            // CurrentLoc
            // 
            this.CurrentLoc.AutoSize = true;
            this.CurrentLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLoc.Location = new System.Drawing.Point(17, 27);
            this.CurrentLoc.Name = "CurrentLoc";
            this.CurrentLoc.Size = new System.Drawing.Size(78, 20);
            this.CurrentLoc.TabIndex = 9;
            this.CurrentLoc.Text = "Location:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeightLabel);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.HealthLabel);
            this.groupBox1.Controls.Add(this.DefenceLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AttackLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CurrentLoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(95, 201);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(0, 20);
            this.WeightLabel.TabIndex = 17;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(17, 201);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(77, 20);
            this.Weight.TabIndex = 17;
            this.Weight.Text = "Strength:";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(105, 132);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(0, 20);
            this.HealthLabel.TabIndex = 16;
            // 
            // DefenceLabel
            // 
            this.DefenceLabel.AutoSize = true;
            this.DefenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefenceLabel.Location = new System.Drawing.Point(105, 97);
            this.DefenceLabel.Name = "DefenceLabel";
            this.DefenceLabel.Size = new System.Drawing.Size(0, 20);
            this.DefenceLabel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gold:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Attack:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Defence:";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackLabel.Location = new System.Drawing.Point(105, 62);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(0, 20);
            this.AttackLabel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Health:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EnemyHealth);
            this.groupBox2.Controls.Add(this.EnemyDefenceLabel);
            this.groupBox2.Controls.Add(this.EnemyAttack);
            this.groupBox2.Controls.Add(this.EnemyType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(325, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 220);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Enemy";
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.AutoSize = true;
            this.EnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealth.Location = new System.Drawing.Point(88, 131);
            this.EnemyHealth.Name = "EnemyHealth";
            this.EnemyHealth.Size = new System.Drawing.Size(0, 20);
            this.EnemyHealth.TabIndex = 18;
            // 
            // EnemyDefenceLabel
            // 
            this.EnemyDefenceLabel.AutoSize = true;
            this.EnemyDefenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDefenceLabel.Location = new System.Drawing.Point(89, 95);
            this.EnemyDefenceLabel.Name = "EnemyDefenceLabel";
            this.EnemyDefenceLabel.Size = new System.Drawing.Size(0, 20);
            this.EnemyDefenceLabel.TabIndex = 19;
            // 
            // EnemyAttack
            // 
            this.EnemyAttack.AutoSize = true;
            this.EnemyAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyAttack.Location = new System.Drawing.Point(88, 59);
            this.EnemyAttack.Name = "EnemyAttack";
            this.EnemyAttack.Size = new System.Drawing.Size(0, 20);
            this.EnemyAttack.TabIndex = 20;
            // 
            // EnemyType
            // 
            this.EnemyType.AutoSize = true;
            this.EnemyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyType.Location = new System.Drawing.Point(88, 23);
            this.EnemyType.Name = "EnemyType";
            this.EnemyType.Size = new System.Drawing.Size(0, 20);
            this.EnemyType.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Defence:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Health:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Attack:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Game Log";
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.TotalWeightLabel);
            this.Inventory.Controls.Add(this.TotalWeight);
            this.Inventory.Controls.Add(this.ShieldLabel);
            this.Inventory.Controls.Add(this.WeaponLabel);
            this.Inventory.Controls.Add(this.ArmourLabel);
            this.Inventory.Controls.Add(this.label12);
            this.Inventory.Controls.Add(this.label13);
            this.Inventory.Controls.Add(this.label14);
            this.Inventory.Location = new System.Drawing.Point(5, 255);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(277, 227);
            this.Inventory.TabIndex = 13;
            this.Inventory.TabStop = false;
            this.Inventory.Text = "Inventory";
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.AutoSize = true;
            this.TotalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeightLabel.Location = new System.Drawing.Point(131, 138);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(0, 20);
            this.TotalWeightLabel.TabIndex = 20;
            this.TotalWeightLabel.TextChanged += new System.EventHandler(this.TotalWeightLabel_TextChanged);
            // 
            // TotalWeight
            // 
            this.TotalWeight.AutoSize = true;
            this.TotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeight.Location = new System.Drawing.Point(17, 139);
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.Size = new System.Drawing.Size(108, 20);
            this.TotalWeight.TabIndex = 21;
            this.TotalWeight.Text = "Total Weight:";
            // 
            // ShieldLabel
            // 
            this.ShieldLabel.AutoSize = true;
            this.ShieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShieldLabel.Location = new System.Drawing.Point(131, 108);
            this.ShieldLabel.Name = "ShieldLabel";
            this.ShieldLabel.Size = new System.Drawing.Size(0, 20);
            this.ShieldLabel.TabIndex = 19;
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.AutoSize = true;
            this.WeaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLabel.Location = new System.Drawing.Point(131, 78);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(0, 20);
            this.WeaponLabel.TabIndex = 18;
            // 
            // ArmourLabel
            // 
            this.ArmourLabel.AutoSize = true;
            this.ArmourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmourLabel.Location = new System.Drawing.Point(131, 43);
            this.ArmourLabel.Name = "ArmourLabel";
            this.ArmourLabel.Size = new System.Drawing.Size(0, 20);
            this.ArmourLabel.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Weapon:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Shield:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Armour:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 573);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.South);
            this.Controls.Add(this.MoveEast);
            this.Controls.Add(this.MoveNorth);
            this.Controls.Add(this.MoveWest);
            this.Name = "Form1";
            this.Text = "Game ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveWest;
        private System.Windows.Forms.Button MoveNorth;
        private System.Windows.Forms.Button MoveEast;
        private System.Windows.Forms.Button South;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label DefenceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.Label EnemyHealth;
        private System.Windows.Forms.Label EnemyDefenceLabel;
        private System.Windows.Forms.Label EnemyAttack;
        private System.Windows.Forms.Label EnemyType;
        private System.Windows.Forms.GroupBox Inventory;
        private System.Windows.Forms.Label ShieldLabel;
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.Label ArmourLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label TotalWeightLabel;
        private System.Windows.Forms.Label TotalWeight;
    }
}

