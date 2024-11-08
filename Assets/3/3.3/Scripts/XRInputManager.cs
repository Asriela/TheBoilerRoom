using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class XRInputManager : MonoBehaviour
{

    [SerializeField] private XRDeviceSimulator _xrDeviceSimulator;
    public InputAction primaryButtonAction;

    private void OnEnable()
    {

        if(_xrDeviceSimulator != null) 
            primaryButtonAction = _xrDeviceSimulator.primaryButtonAction;
        

        if (primaryButtonAction != null)
            primaryButtonAction.performed += OnPrimaryButtonPressed;
        
    }

    private void OnDisable()
    {
        if (primaryButtonAction != null)
            primaryButtonAction.performed -= OnPrimaryButtonPressed;
        
    }


    private void OnPrimaryButtonPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Primary button input works!");

    }

}

