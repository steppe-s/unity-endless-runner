namespace _Scripts
{
    public class Obstacle : LaneObject
    {
        public override void OnCollisionWithPlayer(Player player)
        {
            player.Health -= 1;
        }
    }
}
