using System;
using UnityEngine;

public class CityPlanner : Adult, IGovernmentWorker
{
    public CityPlanner(string id) : base(id) { }

    public override void ShowID()
    {

        Debug.Log($"CityPlanner ID: {ID}");
    }


    public override void Work()
    {
        Debug.Log("first implimentation of work code by hierachy but allows us to call it on all adults");
    }


    public void CommandGovernmentWorker()
    {
        Debug.Log("can command this government worker to do specific UrbanPlanning stuff for the city");
    }
}

