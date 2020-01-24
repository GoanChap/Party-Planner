using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        Dinner_Party dinner;
        Birthday_Party birthday;
        public Form1()
        {
            InitializeComponent();

            birthday = new Birthday_Party((int) birthdayNumericUpDown.Value,
                birthdayDecorCheckBox.Checked, birthdayWritingTextBox.Text.Length);

            dinner = new Dinner_Party((int)dinnerNumericUpDown.Value,
                dinnerFancyDecorCheckBox.Checked, healthyOptionCheckBox.Checked);

            Update_Dinner_Form();
            Update_Birthday_Form();

        }

       
        private void BirthdayWritingTextBox_TextChanged(object sender, EventArgs e)
        {
            birthday.NumberOfLetters = birthdayWritingTextBox.Text.Length;
            birthday.NumberOfPeople = (int)birthdayNumericUpDown.Value;

            Update_Birthday_Form();
        }

        private void BirthdayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            birthday.NumberOfPeople = (int)birthdayNumericUpDown.Value;

            Update_Birthday_Form();
        }

        private void BirthdayDecorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            birthday.FancyDecor = birthdayDecorCheckBox.Checked;
            Update_Birthday_Form();
        }

        private void Update_Birthday_Form()
        {
            decimal Cost = birthday.Cost;
            tooLongLabel.Visible = birthday.CakeWritingTooLong;
            birthdayCostValueLabel.Text = Cost.ToString("c");
        }

        private void DinnerFancyDecorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinner.FancyDecor = dinnerFancyDecorCheckBox.Checked;
            Update_Dinner_Form();
        }

        private void HealthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinner.HealthyOption = healthyOptionCheckBox.Checked;
            Update_Dinner_Form();
        }

        private void DinnerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinner.NumberOfPeople = (int)dinnerNumericUpDown.Value;
            Update_Dinner_Form();
        }

        private void Update_Dinner_Form()
        {
            decimal Cost = dinner.Cost;
            dinnerCostValueLabel.Text = Cost.ToString("c");
        }
    }
}
