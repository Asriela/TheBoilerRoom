using UnityEngine;
using System.Collections.Generic;
using System.Drawing;


public enum Rooms
{
    bedroom,
    livingroom,
    kitchen
}

//since I already did dynamic polymorphism in 1.2 I will do static polymorphism here 
public class PolymorphismExample
{
    public void BuildABuilding(int floors, List<Rooms> rooms)
    {
        Debug.Log("building an apartment complex");
    }

    public void BuildABuilding(List<Rooms> rooms)
    {
        Debug.Log("building a single floor house");
    }

    public void BuildABuilding()
    {
        Debug.Log("building a booth");
    }


}