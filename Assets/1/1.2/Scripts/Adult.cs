using UnityEngine;

public abstract class Adult : Citizen
{
    public abstract void Work();
    public virtual void Commute()
    {
        Debug.Log("standard commute code");
    }
}
