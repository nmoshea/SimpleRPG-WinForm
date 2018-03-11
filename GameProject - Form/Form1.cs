using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace GameProject___Form
{
    public partial class Form1 : Form
    { 
        Player Player1 = new Player(new Location(0,0), new Inventory());   //Initialize Player object
        Character Enemy;
        Item SquareItem;
        IEntity entity;


        public Form1()
        {
            InitializeComponent();
            Map.SetMap();
            Map.PopulateMap();
            groupBox2.Visible = false;
            PlayerStats();
            
        
        }

        private void MoveEast_Click(object sender, EventArgs e)
        {
           
            label1.Text = Player1.MoveTo(Map.Direction.east);
            ProcessSquare();


        }

        private void South_Click(object sender, EventArgs e)
        {
            
           label1.Text = Player1.MoveTo(Map.Direction.south);
            ProcessSquare();


        }

        private void MoveWest_Click(object sender, EventArgs e)
        {
           
           label1.Text = Player1.MoveTo(Map.Direction.west);
            ProcessSquare();


        }

        public void MoveNorth_Click(object sender, EventArgs e)
        {
           
         label1.Text = Player1.MoveTo(Map.Direction.north);
            ProcessSquare();


        }


      public void ProcessSquare()
        {
            textBox1.Clear();
            PlayerStats();
            groupBox2.Hide();
            Map.SetCurrentLocation(Player1._point); //Update Player location on map
             entity = Map.World[Player1._point._x, Player1._point._y];   // get Entity from array.
        
            if (Map.IsOccupied())
            {   
                if (entity is Character)
                {               
                    Enemy = (Character)entity;   
                    
                    textBox1.AppendText(Enemy.EntityName() + " found!\n");
                    CurrentEnemyStats();  // Display Enemy Stats 
                    groupBox2.Visible = true;
                }

                else
                {
                    SquareItem = (Item)entity;
                    textBox1.AppendText(SquareItem.EntityName() + " found!\n");                            

                }

            }
            else
            {
                groupBox2.Hide();
                Enemy = null;
                SquareItem = null;
            }
    
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Attack_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(entity is Character))
                    throw new WrongEntityException();

                textBox1.AppendText("\n\n\n");
                //Player Attack
                if (Player1.AttackSuccess())
                {
                    if (!Enemy.DefenseSucess())   //Enemy defence failed
                    {
                        Player1.Attack(Enemy);
                        textBox1.AppendText("Attack Successfull!\n");
                    }

                    else  //Enemy Defended
                    {
                        textBox1.AppendText("Enemy Defended\n");
                        textBox1.AppendText("Enemies " + Enemy.SpecialRaceAbility() + "\n");
                    }
                }
                else
                    textBox1.AppendText("Attack Missed!\n");

                if (Enemy.IsAlive())
                {

                    //Enemy Retaliation
                    if (Enemy.AttackSuccess())
                    {
                        textBox1.AppendText("The " + Enemy.EntityName() + " is Retaliating\n");
                        if (!Player1.DefenseSucess())  //Players defence failed
                        {
                            Enemy.Attack(Player1);
                            textBox1.AppendText("Enemy attack successfull! \n");
                            if (!Player1.IsAlive())
                            {
                                //Player Dead Game over
                                DialogResult dialog = MessageBox.Show("You have been killed", "Fantasy Game",MessageBoxButtons.OK);
                                if(dialog == DialogResult.OK)
                                {
                                    Application.Exit();
                                }
                              
                            }
                        }
                        else //Players defence was a success
                        {
                            textBox1.AppendText("You have Defended\n");
                            textBox1.AppendText("You:" + Player1.SpecialRaceAbility() + "\n");
                        }
                    }
                    else
                        textBox1.AppendText("Enemy Attack Missed!\n");
                }

                else  //Enemy Killed
                {
                    textBox1.AppendText("The " + Enemy.EntityName() + " has been Killed\n");
                    Map.DeleteEntity();
                    CurrentEnemyStats();
                    entity = null;

                }

                PlayerStats();
                if (!(Enemy == null))
                {
                    CurrentEnemyStats();
                }

            }
            catch (Exception)
            {

            }
        }

        void PlayerStats()
        {
            AttackLabel.Text = Player1._attack.ToString();
            DefenceLabel.Text = Player1._defence.ToString();
            HealthLabel.Text = Player1._health.ToString();
            WeightLabel.Text = Player1._Strength.ToString();
        }

        void CurrentEnemyStats()
        {
            EnemyType.Text = Enemy.EntityName();
            EnemyAttack.Text = Enemy._attack.ToString();
            EnemyDefenceLabel.Text = Enemy._defence.ToString();
            EnemyHealth.Text= Enemy._health.ToString();
        }

        private void PickUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(entity is Item))
                    throw new WrongEntityException();

                if (Player1._charInventory.TotalWeight() + SquareItem._ItemWeight > Player1._Strength)
                     throw new NotStrongEnoughException("The character is not strong Enough");
                
                else
                {
                    if (! Player1._charInventory.AddToInventory(SquareItem, Player1))
                        textBox1.AppendText(SquareItem.EntityName() + " already present!\n");

                    else
                    {//Pickup Item
                        UpdateInventory(Player1._charInventory.ReturnInventory());
                        TotalWeightLabel.Text = Player1._charInventory.TotalWeight().ToString();
                        entity = null; //remove item from board.
                        Map.DeleteEntity();
                    }
                }
            }

            catch(NotStrongEnoughException ex)
            {
                textBox1.AppendText(ex.Message);

            }    
          
            catch(Exception)
            { }

        }

        private void TotalWeightLabel_TextChanged(object sender, EventArgs e)
        {
            if (Player1._charInventory.TotalWeight() == Player1._Strength)
                PickUp.Visible = false;

        }

        private void DropItem(object sender, EventArgs e)
        {





        }

        private void UpdateInventory(List<Item> inventory)
        {
            foreach(Item item in inventory)
            {
                switch (item.GetItemCategory())
                {
                    case ItemCategory.ARMOUR:
                        ArmourLabel.Text = item.EntityName();
                        break;

                    case ItemCategory.WEAPON:
                        WeaponLabel.Text = item.EntityName();
                        break;

                    case ItemCategory.SHIELD:
                        ShieldLabel.Text = item.EntityName();
                        break;

                    default:
                        break;
                }
            }           
        }


    }
}
