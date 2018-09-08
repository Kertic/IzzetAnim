using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWidth = 40;
            int maxHeight = 20;
            PixelGrid pixels = new PixelGrid(maxWidth, maxHeight, 200);
            pixels.SetPixel(0, 0, new Pixel(ConsoleColor.Cyan, 'A'));
            int counter = 0;
            while (true)
            {
                pixels.SetEntireGrid(generateGridIzzet(counter, maxWidth, maxHeight));
                counter++;
                if (counter >= 70)
                    counter = 0;
                Thread.Sleep(200);
            }
        }

        static Pixel[,] generateGridAmerica(int time, int maxX, int maxY)
        {
            Pixel[,] returnArray = new Pixel[maxX, maxY];
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    returnArray[x, y] = new Pixel((time + y + x * maxY) % 2 == 0 ? ConsoleColor.Red : ConsoleColor.White, (char)('▌'));
                }
            }

            for (int x = 0; x < maxX / 3; x++)
            {
                for (int y = 0; y < maxY / 2; y++)
                {
                    int modValue = x + y % (maxX / 3);
                    returnArray[x, y] = new Pixel(
                        modValue % 2 == 0

                        ? ConsoleColor.White : ConsoleColor.Blue,
                        (char)('▌'));
                }
            }
            return returnArray;
        }
        static Pixel[,] generateGridCascade(int time, int maxX, int maxY)
        {
            Pixel[,] returnArray = new Pixel[maxX, maxY];


            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    int modValue = x + y + time % (6);
                    ConsoleColor color = modValue % 3 == 4 ? ConsoleColor.White : ConsoleColor.Blue + (modValue % 6);
                    returnArray[x, y] = new Pixel(color, (char)('▌'));
                }
            }
            return returnArray;
        }
        static Pixel[,] generateGridIzzet(int time, int maxX, int maxY)
        {
            Pixel[,] returnArray = new Pixel[maxX, maxY];


            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    if (x + y >= time)
                        continue;
                    int modValue = x + y + time;
                    ConsoleColor color = ConsoleColor.Cyan;// time % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Cyan;
                    returnArray[x, y] = new Pixel(color, (char)('▌'));
                }
            }

            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {

                    bool isLogo = false;
                    #region Swap on logo positions
                    if (y == 1)
                    {
                        if (x == 20)
                            isLogo = true;
                    }
                    if (y == 2)
                    {
                        if (x == 16)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 24)
                            isLogo = true;
                    }
                    if (y == 4)
                    {
                        if (x == 13)
                            isLogo = true; if (x == 14)
                            isLogo = true; if (x == 15)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 24)
                            isLogo = true; if (x == 25)
                            isLogo = true; if (x == 26)
                            isLogo = true; if (x == 27)
                            isLogo = true;
                    }
                    if (y == 5)
                    {
                        if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 13)
                            isLogo = true; if (x == 14)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 26)
                            isLogo = true; if (x == 27)
                            isLogo = true; if (x == 28)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true;
                    }
                    if (y == 6)
                    {
                        if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 13)
                            isLogo = true; if (x == 18)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 24)
                            isLogo = true; if (x == 25)
                            isLogo = true; if (x == 27)
                            isLogo = true; if (x == 28)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true;
                    }
                    if (y == 7)
                    {
                        if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 17)
                            isLogo = true; if (x == 18)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 24)
                            isLogo = true; if (x == 28)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true;
                    }
                    if (y == 8)
                    {
                        if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 17)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true;
                    }
                    if (y == 9)
                    {
                        if (x == 5)
                            isLogo = true; if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 13)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 27)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true; if (x == 35)
                            isLogo = true;
                    }
                    if (y == 10)
                    {
                        if (x == 5)
                            isLogo = true; if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 14)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 26)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true; if (x == 35)
                            isLogo = true;
                    }
                    if (y == 11)
                    {
                        if (x == 5)
                            isLogo = true; if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 17)
                            isLogo = true; if (x == 18)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 24)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true; if (x == 35)
                            isLogo = true;
                    }
                    if (y == 12)
                    {
                        if (x == 5)
                            isLogo = true; if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 17)
                            isLogo = true; if (x == 18)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 28)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true; if (x == 35)
                            isLogo = true;
                    }
                    if (y == 13)
                    {
                        if (x == 5)
                            isLogo = true; if (x == 6)
                            isLogo = true; if (x == 7)
                            isLogo = true; if (x == 8)
                            isLogo = true; if (x == 9)
                            isLogo = true; if (x == 10)
                            isLogo = true; if (x == 11)
                            isLogo = true; if (x == 12)
                            isLogo = true; if (x == 16)
                            isLogo = true; if (x == 17)
                            isLogo = true; if (x == 18)
                            isLogo = true; if (x == 19)
                            isLogo = true; if (x == 20)
                            isLogo = true; if (x == 21)
                            isLogo = true; if (x == 22)
                            isLogo = true; if (x == 23)
                            isLogo = true; if (x == 24)
                            isLogo = true; if (x == 26)
                            isLogo = true; if (x == 27)
                            isLogo = true; if (x == 28)
                            isLogo = true; if (x == 29)
                            isLogo = true; if (x == 30)
                            isLogo = true; if (x == 31)
                            isLogo = true; if (x == 32)
                            isLogo = true; if (x == 33)
                            isLogo = true; if (x == 34)
                            isLogo = true; if (x == 35)
                            isLogo = true;
                    }
                    if (y == 14)
                    {
                        if (x >= 6 && x <= 34)
                            isLogo = true;
                    }
                    if (y == 15)
                    {
                        if (x >= 7 && x <= 33)
                            isLogo = true;
                    }
                    if (y == 16)
                    {
                        if (x >= 8 && x <= 9)
                            isLogo = true;
                        if (x >= 12 && x <= 28)
                            isLogo = true;
                        if (x >= 30 && x <= 31)
                            isLogo = true;
                    }
                    if (y == 17)
                    {

                        if (x >= 15 && x <= 25)
                            isLogo = true;
                    }
                    if (y == 18)
                    {
                        if (x >= 17 && x <= 23)
                            isLogo = true;
                    }
                    #endregion
                    if (x + y != time)
                        isLogo = !isLogo;
                    ConsoleColor color = returnArray[x, y]._color;
                    if (isLogo)
                    {
                        if (color == ConsoleColor.Cyan)
                            color = ConsoleColor.Red;
                        else
                            color = ConsoleColor.Cyan;
                    }
                    char output = color == ConsoleColor.Red ? 'R' : 'U';

                    returnArray[x, y] = new Pixel(color, output);

                }
            }
            return returnArray;
        }
    }
}
