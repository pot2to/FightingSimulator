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
    public partial class HeroInfo : Form
    {
        /// <summary>
        /// Main Menu object, used to realize somewhat like databinding between MainMenu class and HeroInfo class
        /// </summary>
        private MainMenu mainMenu;

        /// <summary>
        /// Initializes components and fills comboBox1 with heroes from MainMenu class heroes array also realizes data binding between Mainmenu class and HeroInfo class
        /// </summary>
        /// <param name="_mainMenu"></param>
        public HeroInfo(MainMenu _mainMenu)
        {
            this.mainMenu = _mainMenu;
            InitializeComponent();
            for (int i = 0; i < mainMenu.heroes.Count; i++)
            {
                comboBox1.Items.Add(mainMenu.heroes[i]);
            }
        }

        /// <summary>
        /// Shows information about selected hero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hero hero = (Hero)comboBox1.SelectedItem;

                MessageBox.Show("Name - " + hero.Name 
                    + " \nSurname - " + hero.Surname 
                    + "\nNickname - " + hero.Nickname 
                    + "\nAge - " + hero.Age
                    + "\nWeight - " + hero.Weight
                    + "\nStrength - " + hero.Strength);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please choose hero");
            }
        }

        /// <summary>
        /// Closes Hero Information window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
