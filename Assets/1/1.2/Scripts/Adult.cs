using UnityEngine;

public abstract class Adult : Citizen
{
    public Adult() : base() 
    {
        Title = "Adult";
    }

    

    public override void ShowID()
    {
        Debug.Log($"Adult ID: {ID}");
    }
    public abstract void Work();
    public virtual void Commute()
    {
        Debug.Log("standard commute code");
    }
}
