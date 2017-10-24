using System;

public abstract class Block
{
    public Action OnDestroy;
    public Point position;

    public virtual void Destroy()
    {
        if (OnDestroy != null) {
            OnDestroy();
        }
    }
}