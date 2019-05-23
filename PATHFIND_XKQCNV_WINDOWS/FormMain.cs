using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATHFIND_XKQCNV_WINDOWS
{
    public partial class FormMain : Form
    {
        public Map map = new Map();
        private int DebugTest = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        private Button[,] buttons;
        private int ButtonSize = 40;
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Betöltéskor fontosabb értékek beállítása / eventek miatt fontos
            numericUpDownBtnSize.Value = 32;
            ButtonSize = (int)numericUpDownBtnSize.Value;
            labelDisplayConsole.Text = buttonHDisplayConsole.Text;
            //if (map.MapIsValid())
            //{
            //    MessageBox.Show("A map üres!");
            //}
        }
        private void ClearScreen()
        {
            // Még mikor lista volt.
            //foreach (Button item in buttons)
            //{
            //    this.Controls.Remove(item);
            //}
            if (buttons!= null)
            {
                for (int x = 0; x < buttons.GetLength(0); x++)
                {
                    for (int y = 0; y < buttons.GetLength(1); y++)
                    {
                        this.Controls.Remove(buttons[x, y]);
                    }
                }
            }
            buttons = null;
        }
        private void DisplayGrid(int[,] input)
        {
            /// Forrás:
            /// https://stackoverflow.com/questions/4111308/2-dimensional-integer-array-to-datagridview
            /// datagrid view volt programozás 2 része!
            dataGridViewMain.Rows.Clear();
            var rowCount = input.GetLength(0);
            var rowLength = input.GetLength(1);
            dataGridViewMain.ColumnCount = rowLength;
            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();
                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Height = 20;
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = input[rowIndex, columnIndex]
                    });
                }
                dataGridViewMain.Rows.Add(row);
            }
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewMain.Enabled = false;
            dataGridViewMain.ClearSelection();
        }
        private void buttonMakeMap_Click(object sender, EventArgs e)
        {
            ClearScreen();
            map.CreateMap(
                Convert.ToInt32(numericUpDownHeight.Value),
                Convert.ToInt32(numericUpDownLength.Value)
                );
            buttons = new Button[map.Grid.GetLength(0), map.Grid.GetLength(1)];
            for (int i = 0; i < map.Grid.GetLength(0); i++)
            {
                for (int x = 0; x < map.Grid.GetLength(1); x++)
                {
                    Button newButton = new Button();
                    newButton.Text = $"{i} {x}";
                    newButton.BackColor = Color.White;
                    newButton.ForeColor = Color.White;
                    newButton.Width = ButtonSize;
                    newButton.Height = ButtonSize;
                    newButton.Top = 30 + i * ButtonSize;
                    newButton.Left = 15 + x * ButtonSize;
                    newButton.Click += button_Click;
                    buttons[i, x] = newButton;
                    this.Controls.Add(newButton);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < buttons.GetLength(0); x++)
            {
                for (int y = 0; y < buttons.GetLength(1); y++)
                {
                    if (sender == buttons[x,y])
                    {
                        //string[] btnInfo = buttons[y].
                        if (buttons[x, y].BackColor == Color.White)
                        {
                            buttons[x, y].BackColor = Color.Red;
                            buttons[x, y].ForeColor = Color.Red;
                            map.Grid[
                                x,
                                y] = 1;
                        }
                        else if (buttons[x, y].BackColor == Color.Red)
                        {
                            buttons[x, y].BackColor = Color.Green;
                            buttons[x, y].ForeColor = Color.Green;
                            map.Grid[
                                x,
                                y] = 2;
                        }
                        else if (buttons[x, y].BackColor == Color.Green)
                        {
                            buttons[x, y].BackColor = Color.Blue;
                            buttons[x, y].ForeColor = Color.Blue;
                            map.Grid[
                                x,
                                y] = 3;
                        }
                        else if (buttons[x, y].BackColor == Color.Blue)
                        {
                            buttons[x, y].BackColor = Color.White;
                            buttons[x, y].ForeColor = Color.White;
                            map.Grid[
                                x,
                                y] = 0;
                        }
                        else
                        {
                            buttons[x, y].BackColor = Color.Red;
                            buttons[x, y].ForeColor = Color.Red;
                            map.Grid[
                                x,
                                y] = 1;
                        }
                    }
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!map.MapIsValid())
            {
                MessageBox.Show("Adjon meg a pályának egy kezdő / végpontot! Győződjön meg arról is, hogy csak egy darab van belőlük!");
            }
            else
            {
                StartDisplay();
                // Tisztítás
                for (int x = 0; x < map.Grid.GetLength(0); x++)
                {
                    for (int y = 0; y < map.Grid.GetLength(1); y++)
                    {
                        if (buttons[x, y].BackColor == Color.Gold)
                        {
                            buttons[x, y].BackColor = Color.White;
                            buttons[x, y].ForeColor = Color.White;
                            map.Grid[
                                x,
                                y] = 0;
                        }
                    }
                }
                //Kirajzolása az új útvonalnak
                int[,] Display =
                    map.ParentingPart(6);
                for (int x = 0; x < Display.GetLength(0); x++)
                {
                    for (int y = 0; y < Display.GetLength(1); y++)
                    {
                        if (Display[x,y] != 0 && Display[x, y] != 1)
                        {
                            buttons[x, y].Text = $"{Display[x, y]-1}";
                            buttons[x, y].ForeColor = Color.Black;
                            buttons[x, y].BackColor = Color.Gold;
                        }
                    }
                }
            }
        }


        private void StartDisplay()
        {
            map.FindStartAndEnd();
            map.CalculateHValue(map.EndPoint);
        }
        private void buttonOpenListTest_Click(object sender, EventArgs e)
        {
            if (map.MapIsValid())
            {
                StartDisplay();
                int[,] test =
                map.ParentingPart(DebugTest);
                DisplayGrid(test);
            }
        }
        private void buttonHDisplayConsole_Click(object sender, EventArgs e)
        {
            DebugTest = 0;
            labelDisplayConsole.Text = buttonHDisplayConsole.Text;
        }
        private void buttonOLTest_Click(object sender, EventArgs e)
        {
            DebugTest = 1;
            labelDisplayConsole.Text = buttonOLTest.Text;
        }

        private void buttonCLTest_Click(object sender, EventArgs e)
        {
            DebugTest = 2;
            labelDisplayConsole.Text = buttonCLTest.Text;
        }

        private void buttonFValueTest_Click(object sender, EventArgs e)
        {
            DebugTest = 3;
            labelDisplayConsole.Text = buttonFValueTest.Text;
        }

        private void buttonFVSaveTest_Click(object sender, EventArgs e)
        {
            DebugTest = 4;
            labelDisplayConsole.Text = buttonFVSaveTest.Text;
        }

        private void buttonMCTest_Click(object sender, EventArgs e)
        {
            DebugTest = 5;
            labelDisplayConsole.Text = buttonMCTest.Text;
        }

        private void numericUpDownBtnSize_ValueChanged(object sender, EventArgs e)
        {
            // Arány beállítás, dinamikusan. / Ne legyenek túl nagyok a gombok
            numericUpDownHeight.Maximum = 545 / (int)numericUpDownBtnSize.Value;
            numericUpDownLength.Maximum = 545 / (int)numericUpDownBtnSize.Value;
            ButtonSize = (int)numericUpDownBtnSize.Value;
        }
    }
}
