namespace _Scripts.Lane
{
    public class HealthKit : LaneObject
    {
        public override void OnCollisionWithPlayer(Player player)
        {
            player.Health += 1;
            Destroy(gameObject);
        }
    }
}
