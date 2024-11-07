using UnityEngine;

public class Minor : Citizen
{
    public Minor() : base() 
    {
        Title = "Child";
    }

    public override void ShowID()
    {
        Debug.Log($"Child ID: {ID}");
    }

    public void Play()
    {
        Debug.Log("First and only implimentation of play");
    }
}
