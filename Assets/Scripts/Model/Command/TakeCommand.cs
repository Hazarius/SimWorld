public class TakeCommand : ICommand
{
	Unit _actor;
	Food _food;

	public TakeCommand(Unit block, Food food)
	{
		_actor = block;
		_food = food;
	}

	public void Run()
	{
		_actor.Eat(_food);
	}
}