using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATHFIND_XKQCNV_WINDOWS
{
    public class Map
    {
        public int[,] Grid { get; set; }

        // Számoláshoz kellő részek
        public int[,] OpenList { get; set; }
        public int[,] ClosedList { get; set; }

        public int[,] FinishedPath { get; set; }

        public int[,] HValue { get; set; }
        //public int[,] HValueStart { get; set; }
        public int[,] MovementCost { get; set; }

        int[,] FValue { get; set; }
        int[,] FValueSave { get; set; }
        int[,] OpenListBuffer { get; set; }

        public int[] GValue = new int[2] {10,14};
        // Y,X
        public int[] StartPoint = new int[2];
        // Y,X
        public int[] EndPoint = new int[2];
        private bool Finished = false;
        /// Grid tartalma:
        /// 0 = üres mező.
        /// 1 = akadály.
        /// 2 = kezdő pont.
        /// 3 = vég pont.
        public void CreateMap(int Height, int Length)
        {
            Grid = new int[Height,Length];
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    Grid[i, x] = 0;
                }
            }
        }
        public bool MapIsValid()
        {
            if (Grid == null)
            {
                return false;
            }
            else
            {
                bool HasStart = false;
                bool HasEnd = false;
                bool hasDuplicate = false;
                for (int i = 0; i < Grid.GetLength(0); i++)
                {
                    for (int x = 0; x < Grid.GetLength(1); x++)
                    {
                        if (Grid[i,x] == 2)
                        {
                            if (HasStart == false)
                            {
                                HasStart = true;
                            }
                            else
                            {
                                hasDuplicate = true;
                            }
                        }
                        if (Grid[i, x] == 3)
                        {
                            if (HasEnd == false)
                            {
                                HasEnd = true;
                            }
                            else
                            {
                                hasDuplicate = true;
                            }
                        }
                    }
                }
                if (HasStart == true && HasEnd == true && hasDuplicate == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void FindStartAndEnd()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    if (Grid[i,x] == 2)
                    {
                        StartPoint[0] = i;
                        StartPoint[1] = x;
                    }
                    if (Grid[i, x] == 3)
                    {
                        EndPoint[0] = i;
                        EndPoint[1] = x;
                    }
                }
            }
        }
        private void ParentingPartFind()
        {
            //MessageBox.Show("a");
            Finished = false;
            OpenList = new int[Grid.GetLength(0), Grid.GetLength(1)];
            ClosedList = new int[Grid.GetLength(0), Grid.GetLength(1)];
            FinishedPath = new int[Grid.GetLength(0), Grid.GetLength(1)];
            MovementCost = new int[Grid.GetLength(0), Grid.GetLength(1)];
            FValue = new int[Grid.GetLength(0), Grid.GetLength(1)];
            FValueSave = new int[Grid.GetLength(0), Grid.GetLength(1)];
            //Kezdőpont.
            OpenListBuffer = ParentsIgnoreAll(StartPoint[0], StartPoint[1]);
            // Adatok felkerítése
            ClosedList[StartPoint[0], StartPoint[1]] = 1;
            // FCost számolása + OpenList feltöltése
            for (int i = 0; i < OpenListBuffer.GetLength(1); i++)
            {
                OpenList[OpenListBuffer[0, i], OpenListBuffer[1, i]] = 1;
                MovementCost[OpenListBuffer[0, i], OpenListBuffer[1, i]] = GValue[0];
                FValue[OpenListBuffer[0, i], OpenListBuffer[1, i]] = GValue[0] + HValue[OpenListBuffer[0, i], OpenListBuffer[1, i]];
                FValueSave[OpenListBuffer[0, i], OpenListBuffer[1, i]] = GValue[0] + HValue[OpenListBuffer[0, i], OpenListBuffer[1, i]];
            }
            // Melyik a legkisebb Fvalue? x y érték
            int[] Min = new int[3];
            Min[2] = Grid.GetLength(0) * Grid.GetLength(1);
            for (int x = 0; x < FValue.GetLength(0); x++)
            {
                for (int y = 0; y < FValue.GetLength(1); y++)
                {
                    if (FValue[x, y] != 0 && FValue[x, y] < Min[2])
                    {
                        Min[0] = x;
                        Min[1] = y;
                        Min[2] = FValue[x, y];
                    }
                }
            }
            // Ciklus teszt
            //MessageBox.Show($"{Min[0]},{Min[1]} Értéke:{Min[2]}");

            int Cycle = 0;
            ///*
            while (!Finished && Cycle != Grid.GetLength(0) * Grid.GetLength(1))
            {
                OpenListBuffer = Parents(Min[0], Min[1]);
                // Adatok felkerítése
                OpenList[Min[0], Min[1]] = 0;
                ClosedList[Min[0], Min[1]] = 1;
                FValue[Min[0], Min[1]] = 0;
                // FCost számolása + OpenList feltöltése
                for (int x = 0; x < OpenListBuffer.GetLength(1); x++)
                {
                    OpenList[OpenListBuffer[0, x], OpenListBuffer[1, x]] = 1;
                    MovementCost[OpenListBuffer[0, x], OpenListBuffer[1, x]] = MovementCost[Min[0], Min[1]] + GValue[0];
                    FValue[OpenListBuffer[0, x], OpenListBuffer[1, x]] = MovementCost[OpenListBuffer[0, x], OpenListBuffer[1, x]]
                        + HValue[OpenListBuffer[0, x], OpenListBuffer[1, x]];
                    FValueSave[OpenListBuffer[0, x], OpenListBuffer[1, x]] = MovementCost[OpenListBuffer[0, x], OpenListBuffer[1, x]]
                        + HValue[OpenListBuffer[0, x], OpenListBuffer[1, x]];
                }
                // Melyik a legkisebb Fvalue? x y érték
                Min = new int[3];
                Min[0] = 0;
                Min[1] = 0;
                // kell rá optimalizálás
                Min[2] = Grid.GetLength(0) * Grid.GetLength(1) * 50;
                for (int x = 0; x < FValue.GetLength(0); x++)
                {
                    for (int y = 0; y < FValue.GetLength(1); y++)
                    {
                        if (FValue[x, y] != 0 && FValue[x, y] < Min[2])
                        {
                            Min[0] = x;
                            Min[1] = y;
                            Min[2] = FValue[x, y];
                        }
                    }
                }
                Cycle++;
            }
            //*/
            if (Finished == true)
            {
                FinishedPath = MakeFinishedPath();
            }
            else
            {
                MessageBox.Show("Az útvonal keresése sikertelen volt!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //MessageBox.Show($"{Min[0]},{Min[1]} Értéke:{Min[2]}");
        }
        private int[,] MakeFinishedPath()
        {
            int[,] Buffer = new int[Grid.GetLength(0), Grid.GetLength(1)];
            int[,] Result = new int[Grid.GetLength(0), Grid.GetLength(1)];
            // A legnagyobb movement costot keressük előbb.
            int[] Start = new int[3];
            for (int x = 0; x < MovementCost.GetLength(0); x++)
            {
                for (int y = 0; y < MovementCost.GetLength(1); y++)
                {
                    if (MovementCost[x, y] != 0 && MovementCost[x, y] > Start[2])
                    {
                        Start[0] = x;
                        Start[1] = y;
                        Start[2] = MovementCost[x, y];
                    }
                }
            }
            // Legnagyobb érték felrakása a kezdő értékhez. Amit visszaadunk, az egy tömb indexelve a visszamenetet!
            Buffer[Start[0], Start[1]] = Start[2];
            Result[Start[0], Start[1]] = 1;

            int SearchValue = 0;
            int[] Next = new int[3];
            Next = Start;
            int Cycle = 1;
            while (Next[0] != StartPoint[0] || Next[1] != StartPoint[1])
            {
                SearchValue = Next[2] - GValue[0];
                Next = ParentsFinishedPath(Next[0], Next[1], SearchValue);
                if (Next[0] != StartPoint[0] || Next[1] != StartPoint[1])
                {
                    Buffer[Next[0], Next[1]] = SearchValue;
                    Result[Next[0], Next[1]] = Cycle + 1;
                }
                Cycle++;
            }
            return Result;
        }
        public int[] ParentsFinishedPath(int x, int y, int SearchValue)
        {
            // Nincs befejezve megfelelően :(
            // Mindegyik irányt meg kell nézni, van-e akadály.
            // Preferencia miatt kell tudni, melyik irányba mennyünk előbb.
            // 0 = fel
            // 1 = le
            // 2 = jobbra
            // 3 = balra
            int xAxis = 0;
            int yAxis = 0;
            // Irány: Fel
            try
            {
                if (MovementCost[x - 1, y] == SearchValue && ClosedList[x - 1, y] == 1)
                {
                    xAxis = x - 1;
                    yAxis = y;
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Le
            try
            {
                if (MovementCost[x + 1, y] == SearchValue && ClosedList[x + 1, y] == 1)
                {
                    xAxis = x + 1;
                    yAxis = y;
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Jobbra
            try
            {
                if (MovementCost[x, y - 1] == SearchValue && ClosedList[x, y - 1] == 1)
                {
                    xAxis = x;
                    yAxis = y - 1;
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Balra
            try
            {
                if (MovementCost[x, y + 1] == SearchValue && ClosedList[x, y + 1] == 1)
                {
                    xAxis = x;
                    yAxis = y + 1;
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            int[] ret = new int[3];
            ret[0] = xAxis;
            ret[1] = yAxis;
            ret[2] = SearchValue;
            return ret;
        }
        public int[,] ParentingPart(int input)
        {
            ParentingPartFind();
            switch (input)
            {
                case 0:
                    return HValue;
                case 1:
                    return OpenList;
                case 2:
                    return ClosedList;
                case 3:
                    return FValue;
                case 4:
                    return FValueSave;
                case 5:
                    return MovementCost;
                case 6:
                    return FinishedPath;
                default:
                    return FValue;
            }
        }
        public int[,] Parents(int x, int y)
        {
            // Mindegyik irányt meg kell nézni, van-e akadály.
            List<int> xAxis = new List<int>();
            List<int> yAxis = new List<int>();
            // Irány: Fel
            try
            {
                if ((Grid[x - 1, y] == 0 || Grid[x - 1, y] == 3) && ClosedList[x - 1, y] == 0 && OpenList[x,y]==1)
                {
                    xAxis.Add(x-1);
                    yAxis.Add(y);
                    if (Grid[x - 1, y] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Le
            try
            {
                if ((Grid[x + 1, y] == 0 || Grid[x + 1, y] == 3) && ClosedList[x + 1, y] == 0 && OpenList[x, y] == 1)
                {
                    xAxis.Add(x + 1);
                    yAxis.Add(y);
                    if (Grid[x + 1, y] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Jobbra
            try
            {
                if ((Grid[x, y-1] == 0 || Grid[x, y-1] == 3) && ClosedList[x , y-1] == 0 && OpenList[x, y] == 1)
                {
                    xAxis.Add(x);
                    yAxis.Add(y-1);
                    if (Grid[x, y-1] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Balra
            try
            {
                if ((Grid[x, y+1] == 0 || Grid[x, y+1] == 3) && ClosedList[x, y+1] == 0 && OpenList[x, y] == 1)
                {
                    xAxis.Add(x);
                    yAxis.Add(y+1);
                    if (Grid[x, y + 1] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            int[,] ret = new int[2, yAxis.Count];
            for (int i = 0; i < yAxis.Count; i++)
            {
                ret[0,i] = xAxis[i];
                ret[1, i] = yAxis[i];
            }
            return ret;
        }
        public int[,] ParentsIgnoreAll(int x, int y)
        {
            // Mindegyik irányt meg kell nézni, van-e akadály.
            List<int> xAxis = new List<int>();
            List<int> yAxis = new List<int>();
            // Irány: Fel
            try
            {
                if ((Grid[x - 1, y] == 0 || Grid[x - 1, y] == 3))
                {
                    xAxis.Add(x - 1);
                    yAxis.Add(y);
                    if (Grid[x - 1, y] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Le
            try
            {
                if ((Grid[x + 1, y] == 0 || Grid[x + 1, y] == 3))
                {
                    xAxis.Add(x + 1);
                    yAxis.Add(y);
                    if (Grid[x + 1, y] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Jobbra
            try
            {
                if ((Grid[x, y - 1] == 0 || Grid[x, y - 1] == 3))
                {
                    xAxis.Add(x);
                    yAxis.Add(y - 1);
                    if (Grid[x, y - 1] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            // Irány: Balra
            try
            {
                if ((Grid[x, y + 1] == 0 || Grid[x, y + 1] == 3))
                {
                    xAxis.Add(x);
                    yAxis.Add(y + 1);
                    if (Grid[x, y + 1] == 3)
                    {
                        Finished = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Ide nem kerülhet az index.");
            }
            int[,] ret = new int[2, yAxis.Count];
            for (int i = 0; i < yAxis.Count; i++)
            {
                ret[0, i] = xAxis[i];
                ret[1, i] = yAxis[i];
            }
            return ret;
        }
        public void CalculateHValue(int[] Input)
        {
            HValue = new int[Grid.GetLength(0), Grid.GetLength(1)];
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    int yCalc = Input[0]-i;
                    int xCalc = Input[1]-x;
                    if (yCalc < 0)
                    {
                        yCalc *= -1;
                    }
                    if (xCalc < 0)
                    {
                        xCalc *= -1;
                    }
                    HValue[i, x] = yCalc + xCalc;
                }
            }
        }
        //public void CalculateHValueStart(int[] Input)
        //{
        //    HValueStart = new int[Grid.GetLength(0), Grid.GetLength(1)];
        //    for (int i = 0; i < Grid.GetLength(0); i++)
        //    {
        //        for (int x = 0; x < Grid.GetLength(1); x++)
        //        {
        //            int yCalc = Input[0] - i;
        //            int xCalc = Input[1] - x;
        //            if (yCalc < 0)
        //            {
        //                yCalc *= -1;
        //            }
        //            if (xCalc < 0)
        //            {
        //                xCalc *= -1;
        //            }
        //            HValueStart[i, x] = yCalc + xCalc;
        //        }
        //    }
        //}
    }
}
