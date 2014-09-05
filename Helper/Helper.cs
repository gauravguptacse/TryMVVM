using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Windows.Media;

namespace TryMVVM.Helper
{
    public class Helper
    {
        internal static Brush GetRangeIndicator(int range)
        {
            switch (GetRangeMark(range))
            {
                case -1:
                    return (Brush)new BrushConverter().ConvertFromString("#FE2E2E");
                case 0:
                    return (Brush)new BrushConverter().ConvertFromString("#FFFF00");
                case 1:
                    return (Brush)new BrushConverter().ConvertFromString("#FF00B25A");
                default:
                    return (Brush)new BrushConverter().ConvertFromString("#FE2E2E");
            }
        }

        private static int GetRangeMark(int range)
        {
            if (range <= 10)
                return -1;
            else if (range < 50)
                return 0;
            else
                return 1;
        }

        internal static string GetRangeCriticality(int range)
        {
            switch (GetRangeMark(range))
            {
                case -1:
                    return "Critical";
                case 0:
                    return "Mild";
                case 1:
                    return "Normal";
                default:
                    return "Critical";
            }
        }

    }
}