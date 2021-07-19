using System.Collections.Generic;

namespace FloatTool.Models
{
    public class WeaponEqualityComparer : IEqualityComparer<Weapon>
    {
        public bool Equals(Weapon x, Weapon y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null) return false;
            if (y is null) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Label == y.Label;
        }

        public int GetHashCode(Weapon obj)
        {
            var hashCode = (obj.Label != null ? obj.Label.GetHashCode() : 0);
            return hashCode;
        }
    }
}