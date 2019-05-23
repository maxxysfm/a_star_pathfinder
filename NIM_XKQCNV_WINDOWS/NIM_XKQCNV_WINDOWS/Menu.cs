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
    public partial class Menu : Form
    {
        NIM_Game game;
        NIM_Game_Settings settings;
        public Menu()
        {
            InitializeComponent();
            settings = new NIM_Game_Settings();
        }

        private void btn_SettingsGame_Click(object sender, EventArgs e)
        {
            SettingsGame FormSettingsGame = new SettingsGame(settings);
            FormSettingsGame.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Load cuccok ide kerülnének.
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            game = new NIM_Game();
            game.GameReset();
            if (settings.CustomGame.Count() == 0)
            {
                game.GameStart(settings.RowNumb);
                game.CreateGameWithRandomRows(settings.RowMinHeight, settings.RowMaxHeight);
            }
            else
            {
                game.GameStartCustom(settings.CustomGame);
            }
            Game FormGame = new Game(game, settings);
            FormGame.ShowDialog();
        }
    }
}
