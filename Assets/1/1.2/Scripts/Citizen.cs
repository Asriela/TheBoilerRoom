using UnityEngine;
using System;

public abstract class Citizen
{

    public static int CitizenCount=0;
    public string ID { get; protected set; }

    public string Title { get; protected set; }

    public string Name { get; protected set; }

    private static readonly string[] _possibleNames = { "Mike", "Sam", "Joe", "Silva" };

    public Citizen()
    {
        ID = CitizenCount.ToString();
        Title = "Citizen";
        Name = ChooseRandomName(); 
        //increment citizen count each time a new object is made
        CitizenCount++;
    }

    private string ChooseRandomName()
    {
        System.Random random = new System.Random();
        int index = random.Next(_possibleNames.Length);
        return _possibleNames[index];
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
