using UnityEngine;

public class ConstructionWorker : Adult
{
    
    public ConstructionWorker(string id) : base(id) { }

    public override void ShowID()
    {

        Debug.Log($"Construction Worker ID: {ID}");
    }

    public override void Work()
    {
        Debug.Log("first implimentation of work code by hierachy but allows us to call it on all adults");
    }

    public override void Commute()
    {
        Debug.Log("special construction worker commute code");
    }
}
