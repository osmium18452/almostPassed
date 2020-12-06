using System;
using System.Collections.Generic;
using System.Text;

namespace almost_passed
{
    class Draw
    {
        private static string DrawAFloor(int width)
        {
            string s = "";
            s += "│   ";
            for (int i = 0; i < width; i++)
            {
                s += "┌─┐   ";
            }

            s += "│ \n";
            s += "│   ";
            for (int i = 0; i < width; i++)
            {
                s += ("└─┘   ");
            }

            s += ("│ \n");
            return s;
        }

        private static string DrawTop(int width)
        {
            string s = "";
            s += ("┌");
            for (var i = 0; i < width; i++)
            {
                s += ("────");
            }

            s += ("─┐ \n");
            return s;
        }

        private static string DrawGround(int width)
        {
            string s = "";
            s += ("└");
            for (var i = 0; i < width; i++)
            {
                s += ("────");
            }

            s += ("─┴──────────── \n");
            return s;
        }

        private static string DrawYourself(int width)
        {
            string s = "";
            s += ("│   ");
            for (int i = 0; i < width; i++)
            {
                s += ("┌─┐   ");
            }

            s += ("│ \n");
            s += ("│   ");
            for (int i = 0; i < width; i++)
            {
                s += ("└─┘   ");
            }

            s += ("│   ╰?╯\n");

            s += ("│   ");
            for (int i = 0; i < width; i++)
            {
                s += ("┌─┐   ");
            }

            s += ("│    /  \n");
            s += ("│   ");
            for (int i = 0; i < width; i++)
            {
                s += ("└─┘   ");
            }

            s += ("│   />  \n");
            return s;
        }

        private static string DrawTitle(string title)
        {
            string s = "";
            s += ("│               ");
            s += (title);
            var length = Count.GetLen(title);
            for (var i = 0; i < ((4 - length % 4) == 4 ? 0 : (4 - length % 4)); i++) s += (" ");
            s += ("                │\n");
            return s;
        }

        public static string draw(string name, int height, int floor)
        {
            var buildingWidth = Count.GetLen(name);
            var windows = 2 + (3 + buildingWidth) / 4;
            string s = "";
            s += DrawTop(windows);
            s += DrawTitle(name);
            for (var i = 0; i < height - floor; i++) s += DrawAFloor(windows);
            s+=DrawYourself(windows);
            for (var i = 0; i < floor - 2; i++) s+=DrawAFloor(windows);
            s+=DrawGround(windows);
            return s;
        }
    }
}