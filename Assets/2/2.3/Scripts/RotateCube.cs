using UnityEngine;
using System.Collections;
public class RotateCube : MonoBehaviour  
{
    [SerializeField]
    private Vector3 _rotationSpeed = new Vector3(0, 100, 0); 

    private float _initialDelayTime = 1f;



    void Update()
    {
        StartCoroutine( RotateOverTime());
    }


    IEnumerator RotateOverTime()
    {

        yield return new WaitForSeconds(_initialDelayTime);

        transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
        

        
    
}
