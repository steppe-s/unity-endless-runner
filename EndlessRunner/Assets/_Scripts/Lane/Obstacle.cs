namespace _Scripts.Lane
{
    public class Obstacle : LaneObject
    {
        public override void OnCollisionWithPlayer(Player player)
        {
            player.Health -= 1;
        }
    }
}
