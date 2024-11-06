using UnityEngine;

public abstract class Citizen
{
    public string ID { get; protected set; }

    public Citizen(string id)
    {
        ID = id;
    }

    public virtual void ShowID()
    {
        Debug.Log($"Citizen ID: {ID}");
    }
    public void UpdateID(string newID)
    {
        ID = newID;
    }

    public void Eat()
    {
        Debug.Log("do eating code");
    }

    public void Sleep()
    {
        Debug.Log("do sleeping code");
    }
}
