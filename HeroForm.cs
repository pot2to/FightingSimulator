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
        private Hero hero = new Hero();
        private MainMenu mainMenu;
        public HeroForm()
        {
            InitializeComponent();
            this.heroBindingSource.DataSource = hero;
        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu.adder(hero);
            this.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
