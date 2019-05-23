using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NIM_XKQCNV_WINDOWS
{
    public partial class Game : Form
    {
        NIM_Game game;
        NIM_Game_Settings settings;
        private List<Button> buttons = new List<Button>();
        private List<NumericUpDown> numeric = new List<NumericUpDown>();
        private List<PictureBox> pictures = new List<PictureBox>();
        private int Steps = 1;
        private bool PlayerWon = false;
        public Game(NIM_Game ActiveGame,NIM_Game_Settings InpSettings)
        {
            InitializeComponent();
            this.game = ActiveGame;
            this.settings = InpSettings;
        }
        private void ComputerTurn()
        {
            WriteToConsole("A gép lépése következik.");
            int xor = 0;
            int x = 0;
            bool Step = false;
            int CountFullRows = 0;
            for (int i = 0; i < game.Rows.Length; i++)
            {
                if (game.Rows[i] != 0)
                {
                    CountFullRows++;
                }
            }
            for (int i = 0; i < game.Rows.Length; i++)
            {
                if (game.Rows[i] != 0)
                {
                    xor ^= game.Rows[i];
                }
            }
            if (xor == 0)
            {
                do
                {
                    if (game.Rows[x] != 0 && CountFullRows == 1)
                    {
                        game.RemoveFromRows(1,x);
                        Step = true;
                    }
                    else if (game.Rows[x] != 0)
                    {
                        game.RemoveFromRows(game.Rows[x], x);
                        Step = true;
                    }
                    x++;
                } while (Step == false && x < game.Rows.Count());
                if (CountFullRows == 0)
                {
                    PlayerWon = true;
                    PlayerWin(true);
                }
                else
                {
                    WriteToConsole($"{Steps}: A gép lépése: {x}. oszlopból elvett {game.Rows[x]} ceruzát!");
                }
            }
            else
            {
                int subtract = 0;
                int operation = 0;
                do
                {
                    // 7
                    // 5
                    // removefromrows
                    // 2
                    if (game.Rows[x] != 0)
                    {
                        subtract = game.Rows[x] ^ xor;
                        operation = game.Rows[x] - subtract;
                        if (CountFullRows == 1)
                        {
                            game.RemoveFromRows(game.Rows[x], x);
                            operation = game.Rows[x];
                            Step = true;
                        }
                        // Nem szükséges
                        //else if (CountFullRows == 1 && game.Rows[x] <= 2)
                        //{
                        //    game.RemoveFromRows(1, x);
                        //    operation = 1;
                        //    Step = true;
                        //}
                        //else if (CountFullRows == 1 && game.Rows[x] % 2 != 0)
                        //{
                        //    game.RemoveFromRows(1, x);
                        //    operation = 1;
                        //    Step = true;
                        //}
                        else if (operation > 0)
                        {
                            game.RemoveFromRows(operation, x);
                            Step = true;
                        }
                    }
                    x++;
                } while (Step == false && x < game.Rows.Count());
                WriteToConsole($"{Steps}: A gép lépése: {x}. oszlopból elvett {operation} ceruzát!");
            }
            //WriteToConsole(Convert.ToString(result));
            if (PlayerWon == false)
            {
                WriteToConsole("A játékos lépése következik.");
            }
        }
        private void WriteToConsole(string Input)
        {
            listBoxConsole.Items.Add($"{Input}");
            listBoxConsole.TopIndex = listBoxConsole.Items.Count - 1;
        }
        private void ClearConsole()
        {
            listBoxConsole.Items.Clear();
        }
        private void ClearScreen()
        {
            foreach (Button item in buttons)
            {
                this.Controls.Remove(item);
            }
            buttons.Clear();
            foreach (PictureBox item in pictures)
            {
                this.Controls.Remove(item);
            }
            pictures.Clear();
            foreach (NumericUpDown item in numeric)
            {
                this.Controls.Remove(item);
            }
            numeric.Clear();
        }
        private void RefreshScreen()
        {
            int Placement = 0;
            for (int i = 0; i < game.Rows.Length; i++)
            {
                int yCord = 450;
                Button newButton = new Button();
                newButton.Text = $"{buttons.Count + 1}. sor ({game.Rows[i]})";
                newButton.Top = 465;
                newButton.Left = 25 + Placement;
                NumericUpDown newNumericUpDown = new NumericUpDown();
                newNumericUpDown.Minimum = 1;
                newNumericUpDown.Maximum = game.Rows[i];
                newNumericUpDown.Top = 488;
                newNumericUpDown.Left = 30 + Placement;
                newNumericUpDown.Width = 65;
                //https://stackoverflow.com/questions/6187944/how-can-i-create-a-dynamic-button-click-event-on-a-dynamic-button
                //newButton.Click += new EventHandler(btn_Click);
                newButton.Click += button_Click;

                numeric.Add(newNumericUpDown);
                this.Controls.Add(newNumericUpDown);

                buttons.Add(newButton);
                this.Controls.Add(newButton);

                Placement += 100;
                for (int x = 0; x < game.Rows[i]; x++)
                {
                    var pen = new PictureBox
                    {
                        Name = $"Pen{i}:{x}",
                        Size = new Size(50, 8),
                        Location = new Point(Placement - 60, yCord),
                        ImageLocation = Application.StartupPath + "\\pen.png",
                    };
                    yCord -= 8;
                    pictures.Add(pen);
                    this.Controls.Add(pen);
                    pen.BringToFront();
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < buttons.Count; y++)
            {
                if (sender == buttons[y])
                {
                    int CountFullRows = 0;
                    for (int i = 0; i < game.Rows.Length; i++)
                    {
                        if (game.Rows[i] != 0)
                        {
                            CountFullRows++;
                        }
                    }
                    //if (CountFullRows == 1 && Convert.ToInt32(numeric[y].Value) == game.Rows[y] && game.Rows[y] != 1)
                    //{
                    //    MessageBox.Show("A játék megnyeréséhez az utolsó ceruzát kell felvenni!");
                    //}
                    // else if (game.RemoveFromRows(Convert.ToInt32(numeric[y].Value),y))
                    if (game.RemoveFromRows(Convert.ToInt32(numeric[y].Value),y))
                    {
                        WriteToConsole($"{Steps}: A játékos lépése: {buttons.Count - y}. oszlopból elvett {Convert.ToInt32(numeric[y].Value)} ceruzát!");
                        Steps++;
                        ComputerTurn();
                        ClearScreen();
                        RefreshScreen();
                    }
                    if (game.CheckGameDone())
                    {
                        PlayerWin(false);
                    }
                }
            }
        }
        private void Refresh_Labels()
        {
                labelWinCond.Text = "Ha felveszi az utolsó ceruzát, akkor veszít!";
        }
        private void Game_Load(object sender, EventArgs e)
        {
            Refresh_Labels();
            RefreshScreen();
        }
        private void PlayerWin(bool Win)
        {
            if (Win && PlayerWon == true)
            {
                MessageBox.Show("Gratulálunk! Ön legyőzte a számítógépes ellenséget!","Győzelem!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                WriteToConsole("A játékos megnyerte a játékot!");
            }
            else if(!Win && PlayerWon == false)
            {
                MessageBox.Show("A számítógép megnyerte a játékot!", "Próbálja meg újra!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                WriteToConsole("A számítógép megnyerte a játékot!");
            }
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            //PlayerWin(false);
            this.Close();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //PlayerWin(false);
            PlayerWon = false;
            ClearScreen();
            if (settings.CustomGame.Count == 0)
            {
                game.GameReset();
                game.GameStart(settings.RowNumb);
                game.CreateGameWithRandomRows(settings.RowMinHeight, settings.RowMaxHeight);
            }
            else
            {
                game.GameReset();
                game.GameStartCustom(settings.CustomGame);
            }
            Steps = 1;
            ClearConsole();
            RefreshScreen();
        }
    }
}
