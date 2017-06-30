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
    public partial class HeroForm : Form
    {
        /// <summary>
        /// Hero object, used to store information about created hero
        /// </summary>
        private Hero hero = new Hero();

        /// <summary>
        /// Main Menu object, used to realize somewhat like databinding between MainMenu class and HeroForm class
        /// </summary>
        private MainMenu mainMenu;

        /// <summary>
        /// Initializes components and data binding also realizes data binding between Mainmenu class and HeroForm class
        /// </summary>
        public HeroForm(MainMenu _mainMenu)
        {
            this.mainMenu = _mainMenu;
            InitializeComponent();
            this.heroBindingSource.DataSource = hero;
        }

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        /// <summary>
        /// Calls for the MainMenu class method called adder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu.adder(hero);
            this.Close();
        }
        
        /// <summary>
        /// Closes Hero Form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
