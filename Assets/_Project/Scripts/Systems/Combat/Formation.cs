using System.Collections.Generic;

namespace Assets._Project.Scripts.Systems.Combat
{
    // One side's battlefield arrangement: a fixed number of lanes, each an
    // ordered list of units from front (index 0) to back. Removing a dead
    // unit from a lane's list automatically promotes the next unit to front —
    // no manual re-numbering needed.
    public class Formation
    {
        public List<CombatUnit>[] Lanes;

        public Formation(int laneCount)
        {
            Lanes = new List<CombatUnit>[laneCount];
            for (int i = 0; i < laneCount; i++)
                Lanes[i] = new List<CombatUnit>();
        }

        public CombatUnit GetFront(int lane) => Lanes[lane].Count > 0 ? Lanes[lane][0] : null;
        public CombatUnit GetBack(int lane) => Lanes[lane].Count > 0 ? Lanes[lane][^1] : null;
        public IReadOnlyList<CombatUnit> GetAll(int lane) => Lanes[lane];
    }
}