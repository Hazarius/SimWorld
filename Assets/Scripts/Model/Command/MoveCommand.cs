public class MoveCommand : ICommand
{
    Block _block;
    EDirection _direction;
    public MoveCommand (Block block, EDirection direction)
    {
        _block = block;
        _direction = direction;
    }

    public void Run()
    {
        _block.position += Point.GetPoint(_direction);
    }
}