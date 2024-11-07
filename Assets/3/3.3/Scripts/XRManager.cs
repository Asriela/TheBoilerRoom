using UnityEngine;
using UnityEngine.XR;
public class XRManager : MonoBehaviour
{
    private InputDevice leftController;
    private InputDevice rightController;

    void Start()
    {
        // Start the XR Session (simulated here for the example)
      //  StartXRSession();
    
        // Initialize input devices for both hands
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

}
