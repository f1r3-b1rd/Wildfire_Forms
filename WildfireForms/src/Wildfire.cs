using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WildfireForms
{
    class Wildfire
    {
        // Any usage of the word matrix is used to refer to the multidimensional int array stored in the field variable
        public int speedModifier = 0;
        int[,] field = new int[100, 100];
        int[,] fTimer = new int[100, 100];
        Bitmap bm;
        Graphics gfx;
        Color green = Color.FromArgb(0, 255, 0);
        Color red = Color.FromArgb(255, 0, 0);
        Color dark = Color.FromArgb(0, 0, 0);

        public Form1 runner;
        public int plantProbability = 50;
        public int fireProbability = 50;
        public int growthRate = 5;
        public int burnRate = 2;

        public Wildfire()
        {
            bm = new Bitmap(500, 500);
            gfx = Graphics.FromImage(bm);
            FillField();
        }

        public void Begin()
        {
            while (true)
            {
                Iterate(plantProbability, fireProbability);

                gfx.Save();
                runner.wfPictureBox.Image = bm;
                Thread.Sleep(1000 - (100 * speedModifier));
                // Console.Write(t + " ");
            }
        }

        void Iterate(int growProbability, int burnProbability)
        {
            Random rand = new Random();
            // The following are stored as type int in the array "field" that indicate what the current state of that "unit" is
            // 0 Empty
            // 1 Growing
            // 2 Occupied
            // 3 Burning
            // 4 Will be burning

            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    // Check if cell is being planted
                    if (field[r, c] == 0)
                    {
                        if (rand.Next(1, 101) <= growProbability)
                        {
                            field[r, c] = 1;
                        }
                    }
                    // Check if cell is done growing
                    else if (field[r, c] == 1)
                    {
                        if (fTimer[r, c] == growthRate)
                        {
                            field[r, c] = 2;
                        }
                        else
                        {
                            fTimer[r, c]++;
                            gfx.FillRectangle(new SolidBrush(Color.FromArgb(0, (250 / growthRate) * fTimer[r, c], 0)), new Rectangle(c * 5, r * 5, 5, 5));
                        }
                    }
                    // Check if occupied space needs to be burned
                    else if (field[r, c] == 2 || field[r, c] == 1)
                    {
                        IEnumerable<int> adj = AdjElements(field, r, c);
                        if (adj.Contains(3) || rand.Next(1, 101) <= burnProbability)
                        {
                            fTimer[r, c] = 0;
                            field[r, c] = 3;
                            gfx.FillRectangle(new SolidBrush(red), new Rectangle(c * 5, r * 5, 5, 5));
                        }
                    }
                    // Check if occupied space is still burning
                    else if (field[r, c] == 3)
                    {
                        // Burn for 2 cycles
                        if (fTimer[r, c] == burnRate)
                        {
                            fTimer[r, c] = 0;
                            field[r, c] = 0;
                            gfx.FillRectangle(new SolidBrush(dark), new Rectangle(c * 5, r * 5, 5, 5));
                        }
                        else
                        {
                            fTimer[r, c]++;
                        }
                    }
                }
            }
        }

        // Populate the field matrix with empty integers
        void FillField()
        {
            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    field[r, c] = 0;
                    fTimer[r, c] = 0;
                }
            }
        }

        public void Reset()
        {
            bm = new Bitmap(500, 500);
            gfx = Graphics.FromImage(bm);
            FillField();
        }

        // Populate adjacent matrix elements into an IEnumerable
        IEnumerable<T> AdjElements<T>(T[,] arr, int row, int column)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            for (int j = row - 1; j <= row + 1; j++)
                for (int i = column - 1; i <= column + 1; i++)
                    if (i >= 0 && j >= 0 && i < columns && j < rows && !(j == row && i == column))
                        yield return arr[j, i];
        }
    }
}
