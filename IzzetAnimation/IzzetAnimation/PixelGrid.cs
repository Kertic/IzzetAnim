using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzzetAnimation
{
    struct Pixel
    {
        public ConsoleColor _color;
        public char _character;
        public Pixel(ConsoleColor color, char inChar)
        {
            _color = color;
            _character = inChar;
        }
        public static bool operator ==(Pixel pa, Pixel pb)
        {
            if (pa._color != pb._color)
                return false;
            if (pa._character != pb._character)
                return false;

            return true;
        }
        public static bool operator !=(Pixel pa, Pixel pb)
        {
            return !(pa == pb);
        }
    }
    class PixelGrid
    {
        int gridWidth;
        int gridHeight;
        Pixel[,] displayBuffer;
        Pixel[,] previousBuffer;
        System.Timers.Timer aTimer;



        public PixelGrid(int windowWidth, int windowHeight, int refreshRate)
        {

            gridWidth = windowWidth;
            gridHeight = windowHeight;
            Console.WindowWidth = windowWidth;
            Console.WindowHeight = windowHeight;
            displayBuffer = new Pixel[gridWidth, gridHeight];
            previousBuffer = new Pixel[gridWidth, gridHeight];
            SetTimer(refreshRate);
        }

        public void SetPixel(int x, int y, Pixel inPixel)
        {
            if (x < 0 || y < 0 || x >= gridWidth || y >= gridWidth)
            {
                throw new Exception("Attempting to set pixel out of range");
            }

            displayBuffer[x, y] = inPixel;
        }
        public void SetEntireGrid(Pixel[,] inGrid)
        {
            if (inGrid.GetLength(0) != gridWidth || inGrid.GetLength(1) != gridHeight)
                throw new Exception("Grids do not align");

            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    displayBuffer[x, y] = inGrid[x, y];
                }
            }
        }
        private void SetTimer(int time)
        {

            aTimer = new System.Timers.Timer(time);
            aTimer.Elapsed += OnPrivateTick;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnPrivateTick(object obj, System.Timers.ElapsedEventArgs args)
        {
           
            RefreshScreen();
        }
        private void RefreshScreen()
        {
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    if (displayBuffer[x, y] != previousBuffer[x, y])
                    {
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = displayBuffer[x, y]._color;
                        Console.Write(displayBuffer[x, y]._character);
                    }
                }
            }
            CopyBuffer();
        }
        private void CopyBuffer()
        {
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    previousBuffer[x, y] = displayBuffer[x, y];
                }
            }
        }
    }
}
