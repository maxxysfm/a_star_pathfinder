using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM_XKQCNV_WINDOWS
{
    public partial class SettingsGame : Form
    {
        NIM_Game_Settings settings;
        private List<int> CustomGame = new List<int>();
        public SettingsGame(NIM_Game_Settings InpGameSettings)
        {
            InitializeComponent();
            this.settings = InpGameSettings;
            if (settings.RowNumb == 0)
            {
                settings.RowNumb = 3;
                settings.RowMinHeight = 3;
                settings.RowMaxHeight = 10;
            }
            numericUpDownRows.Value = Convert.ToDecimal(settings.RowNumb);
            numericUpDownMin.Value = Convert.ToDecimal(settings.RowMinHeight);
            numericUpDownMax.Value = Convert.ToDecimal(settings.RowMaxHeight);
            //cmbWincondition.SelectedIndex = Convert.ToInt32(settings.lastWins);
        }
        private void SettingsGame_Load(object sender, EventArgs e)
        {
            numericUpDownCustomGameRows.Value = 13;
            numericUpDownCustomGameRows.Value = 12;
            numericUpDownCustomGameRows.Maximum = 12;
            if (settings.CustomGame.Count == 0)
            {
                numericUpDownCustomGameRows.Value = 2;
                cmbSave.SelectedIndex = 0;
            }
            else
            {
                CustomGame = settings.CustomGame;
                numericUpDownCustomGameRows.Value = CustomGame.Count;
                cmbSave.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSave.SelectedIndex == 1)
            {
                settings.CustomGame = CustomGame;
            }
            else if (cmbSave.SelectedIndex == 0)
            {
                settings.RowNumb = Convert.ToInt32(numericUpDownRows.Value);
                settings.RowMinHeight = Convert.ToInt32(numericUpDownMin.Value);
                settings.RowMaxHeight = Convert.ToInt32(numericUpDownMax.Value);
                //settings.lastWins = Convert.ToBoolean(cmbWincondition.SelectedIndex);
                settings.CustomGame.Clear();
            }
            this.Close();
        }

        private void cmbSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSave.SelectedIndex == 0)
            {
                groupBoxCustom.Enabled = false;
                groupBoxRandom.Enabled = true;
            }
            else
            {
                groupBoxCustom.Enabled = true;
                groupBoxRandom.Enabled = false;
            }
        }
        private void numericUpDownCustomGameRows_ValueChanged(object sender, EventArgs e)
        {
            List<int> temp = new List<int>();
            temp.AddRange(CustomGame);
            CustomGame.Clear();
            comboBoxCustomGameIndex.Items.Clear();
            for (int i = 0; i < numericUpDownCustomGameRows.Value; i++)
            {
                if (i < temp.Count())
                {
                    CustomGame.Add(temp[i]);
                }
                else
                {
                    CustomGame.Add(1);
                }
                comboBoxCustomGameIndex.Items.Add($"{i+1}");
            }
            comboBoxCustomGameIndex.SelectedIndex = 0;
        }

        private void comboBoxCustomGameIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //numericUpDownCustomGameRows.Value = CustomGame[Convert.ToInt32(numericUpDownCustomGameRows.Value)];
            numericUpDownCustomAmount.Value = CustomGame[comboBoxCustomGameIndex.SelectedIndex];
        }

        private void numericUpDownCustomAmount_ValueChanged(object sender, EventArgs e)
        {
            CustomGame[comboBoxCustomGameIndex.SelectedIndex] = Convert.ToInt32(numericUpDownCustomAmount.Value);
        }
    }
}
