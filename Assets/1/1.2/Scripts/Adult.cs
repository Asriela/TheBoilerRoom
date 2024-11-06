using UnityEngine;

public abstract class Adult : Citizen
{
    public Adult(string ID) : base(ID) { }

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
