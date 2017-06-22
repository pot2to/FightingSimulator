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
        private MainMenu mainMenu;
        public HeroInfo()
        {
            InitializeComponent();
        }

        public HeroInfo(MainMenu _mainMenu)
        {
            this.mainMenu = _mainMenu;
            InitializeComponent();
            for (int i = 0; i < mainMenu.heroes.Count; i++)
            {
                comboBox1.Items.Add(mainMenu.heroes[i]);
            }
        }

        private void HeroInfo_Load(object sender, EventArgs e)
        {

        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
