public class RestCommand : ICommand
{
	Unit _actor;
	public RestCommand(Unit actor)
	{
		_actor = actor;
	}

	public void Run()
	{
		_actor.Rest();
	}
}