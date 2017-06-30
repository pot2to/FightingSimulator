using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightingSimulator
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Array which contains all heroes
        /// </summary>
        public List<Hero> heroes = new List<Hero>();

        /// <summary>
        /// Number which increments as heroes are created, used to navigate through heroes array
        /// </summary>
        private int heroNumber = 0;

        /// <summary>
        /// Initializes components
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds hero given as parameter to comboBox1 and comboBox2
        /// </summary>
        /// <param name="hero"></param>
        public void adder(Hero hero)
        {
            heroes.Add(hero);
            comboBox1.Items.Add(heroes[heroNumber]);
            comboBox2.Items.Add(heroes[heroNumber]);
            MessageBox.Show(heroes[heroNumber] + " added successfully!");
            heroNumber++;            
        }

        public List<Hero> Heroes
        {
            get { return heroes; }
            set { heroes = value; }
        }

        /// <summary>
        /// Creates new object of Hero Form window and shows it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            HeroForm heroForm = new HeroForm(this);
            heroForm.Show();
        }

        /// <summary>
        /// Closes main menu window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Takes information about chosen heroes from combobox and generates output based on heroes parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Hero hero1 = (Hero)comboBox1.SelectedItem;
            Hero hero2 = (Hero)comboBox2.SelectedItem;

            try
            {
                if (((hero1.Age - hero2.Age) <= 20) && (hero1.Age - hero2.Age) >= -20)
                {
                    if (((hero1.Weight - hero2.Weight) <= 20) && (hero1.Weight - hero2.Weight) >= -20)
                    {
                        if (((hero1.Strength - hero2.Strength) <= 15) && (hero1.Strength - hero2.Strength) >= -15)
                        {
                            if (hero1.Strength > hero2.Strength)
                                MessageBox.Show(hero1.Nickname + " won, because he's stronger!");
                            else if (hero2.Strength > hero1.Strength)
                                MessageBox.Show(hero2.Nickname + " won, because he's stronger!");
                            else
                                MessageBox.Show("Draw!");
                        }
                        else if ((hero1.Strength - hero2.Strength) > 15)
                            MessageBox.Show(hero1.Nickname + " won, because " + hero2.Nickname + " is too weak to fight him!");
                        else if ((hero1.Strength - hero2.Strength) < -15)
                            MessageBox.Show(hero2.Nickname + " won, because " + hero1.Nickname + " is too weak to fight him!");
                        else
                            MessageBox.Show("Draw!");

                    }
                    else if ((hero1.Weight - hero2.Weight) > 20)
                        MessageBox.Show(hero1.Nickname + " won, because size matters!");
                    else if ((hero1.Weight - hero2.Weight) < -20)
                        MessageBox.Show(hero2.Nickname + " won, because size matters!");
                    else
                        MessageBox.Show("Draw!");

                }
                else if ((hero1.Age - hero2.Age) > 20)
                    MessageBox.Show(hero1.Nickname + " won, because " + hero2.Nickname + " is too old to fight him!");
                else if ((hero1.Age - hero2.Age) < -20)
                    MessageBox.Show(hero2.Nickname + " won, because " + hero1.Nickname + " is too old to fight him!");
                else
                    MessageBox.Show("Draw!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please, choose heroes to fight");
            }
        }

        /// <summary>
        /// Creates new object of Hero Information window and shows it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            HeroInfo heroInfo = new HeroInfo(this);
            heroInfo.Show();
        }
    }
}
