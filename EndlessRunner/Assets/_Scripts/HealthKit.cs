namespace _Scripts
{
    public class HealthKit : LaneObject
    {
        public override void OnCollisionWithPlayer(Player player)
        {
            player.Health += 1;
        }
    }
}
