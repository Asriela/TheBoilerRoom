using UnityEngine;
using System.Collections;
public class RotateCube : MonoBehaviour  
{
    [SerializeField]
    private Vector3 _rotationSpeed = new Vector3(0, 100, 0); 

   

    void Update()
    {
        RotateOverTime();
    }


    public void RotateOverTime()
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
        

        
    
}
