namespace Assets._Project.Scripts.Systems.Combat
{
    public class CombatState
    {
        public Formation playerFormation;
        public Formation enemyFormation;
        public int currentWave;

        public CombatState(int laneCount)
        {
            playerFormation = new Formation(laneCount);
            enemyFormation = new Formation(laneCount);
            currentWave = 0;
        }

        public int IncrementWave()
        {
            currentWave++;
            return currentWave;
        }
    }
}