using TMPro;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class XRInputManager : MonoBehaviour
{


    private InputData _inputData;

    private float triggerValue;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
    }
    // Update is called once per frame
    void Update()
    {
        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            //_leftMaxScore = theFloat;
       
            Debug.Log("triggerValue: " + triggerValue);
        }

        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton))
        {
            //_leftMaxScore = theFloat;
           
            Debug.Log("A button: " + Abutton);
        }

        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool Bbutton))
        {
            Debug.Log("B button: " + Bbutton);
        }

    }



 
    
}

