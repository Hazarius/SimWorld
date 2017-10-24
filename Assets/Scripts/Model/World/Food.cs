public class Food : Block
{
	public int hpBonus;
	public Food() {}
	public Food(int hp)
	{
		hpBonus = hp;
	}

	public override void Destroy()
	{
		base.Destroy();
		Game.objects.RemoveObject(this);
	}
}