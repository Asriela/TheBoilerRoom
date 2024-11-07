using UnityEngine;
using UnityEngine.XR.Management;
using UnityEngine.XR;

public class XRManager : MonoBehaviour
{



    void Start()
    {
        // Start XR session
        StartXRSession();
    }

    void Update()
    {
        
        // Handle input from left hand controller
        InputDevice leftHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        var value= leftHandDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed);
        if (value )
        {
            Debug.Log("Primary button on left controller is pressed.");
        }
    }

    void StartXRSession()
    {
        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            XRGeneralSettings.Instance.Manager.InitializeLoaderSync();
        }

        if (!XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            XRGeneralSettings.Instance.Manager.StartSubsystems();
            Debug.Log("XR session started.");
        }
    }

    void StopXRSession()
    {
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
        Debug.Log("XR session stopped.");
    }
}

