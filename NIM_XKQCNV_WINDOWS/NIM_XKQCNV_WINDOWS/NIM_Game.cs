using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM_XKQCNV_WINDOWS
{
    public class NIM_Game
    {
        public int[] Rows { get; set; }
        // Az nyerjen, aki a legutolsót felszedi?
        //public bool lastWins = false;
        public bool GameExists()
        {
            if (Rows == null)
            {
                return true;
            }
            else
            {
                //MessageBox.Show("Már vannak sorai ennek a játéknak!");
                return false;
            }
        }
        public void GameReset()
        {
            Rows = null;
        }
        public bool GameStart(int numberOfRows)
        {
            if (numberOfRows < 1)
            {
                //MessageBox.Show("Szükséges minimum 1 sor!");
                return false;
            }
            else if (GameExists())
            {
                //lastWins = lastwins;
                Rows = new int[numberOfRows];
                //if (lastwins)
                //{
                //    //MessageBox.Show("A játék sikeresen létre lett hozva! Az nyer, aki a legutolsó elemet veszi fel!");
                //}
                //else
                //{
                //    //MessageBox.Show("A játék sikeresen létre lett hozva! Az veszt, aki a legutolsó elemet veszi fel!");
                //}
                return true;
            }
            else
            {
                //MessageBox.Show("A játék létrehozása sikertelen. Már léteznek sorai ennek a játéknak!");
                return false;
            }
        }
        public bool GameStartCustom(List<int> CustomRows)
        {
            if (CustomRows.Count < 1)
            {
                //MessageBox.Show("Szükséges minimum 1 sor!");
                return false;
            }
            else if (GameExists())
            {
                //lastWins = lastwins;
                Rows = new int[CustomRows.Count];
                for (int i = 0; i < CustomRows.Count; i++)
                {
                    Rows[i] = CustomRows[i];
                }
                return true;
            }
            else
            {
                //MessageBox.Show("A játék létrehozása sikertelen. Már léteznek sorai ennek a játéknak!");
                return false;
            }
        }
        public bool CreateGameWithRandomRows(int minValues, int maxValues)
        {
            if (minValues > maxValues)
            {
                //MessageBox.Show("A Minimális értéknek kisebbnek kell lennie, mint a Maximum!");
                return false;
            }
            // Feltételezzük, hogy a játék készítésekor sose változik majd a sorok száma! az hogy egy sor tartalmazhat 0 elemet, az már magától érthető.
            else if (!GameExists())
            {
                Random r = new Random();
                for (int i = 0; i < Rows.Length; i++)
                {
                    // Kell a +1 mert a max-ot sose éri el különben, attól függ hogyan akarjuk a logikát
                    Rows[i] = r.Next(minValues, maxValues + 1);
                }
                //MessageBox.Show("A játék sikeresen fel lett töltve!");
                return true;
            }
            else
            {
                //MessageBox.Show("A véletlenszerű elemek létrehozása során probléma lépett fel! A játék újra indítása megoldhatja a problémát.");
                return false;
            }
        }
        public bool CheckGameDone()
        {
            int Count = 0;
            for (int i = 0; i < Rows.Length; i++)
            {
                Count+=Rows[i];
            }
            if (Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveFromRows(int Amount,int Index)
        {
            try
            {
                Rows[Index] -= Amount;
                if (Amount <= 0)
                {
                    return false;
                }
                else if (Rows[Index] < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

