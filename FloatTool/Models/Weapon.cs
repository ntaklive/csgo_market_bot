using System.Collections.Generic;
using System.Drawing;

namespace FloatTool.Models
{
    public class Weapon
    {
        public static WeaponEqualityComparer EqualityComparer { get; } = new();

        public string Label { get; set; }
        public double Float { get; set; }
        public double Price { get; set; }
        public Color RarityColor { get; set; }
    }
}