using UnityEngine;
using SG;   // for SG_BasicGesture

public class PlanetGestureRotation : MonoBehaviour
{
    [Header("Gesture Input")]
    public SG_BasicGesture rotationGesture;  // assign in Inspector (from your SGHand prefab)

    [Header("Rotation Settings")]
    public Vector3 rotationAxis = new Vector3(0, 1, 0);  // default: spin around Y axis
    public float rotationSpeed = 20f;  // degrees per second

    void Update()
    {
        if (rotationGesture != null && rotationGesture.IsGesturing)
        {
            // Apply continuous rotation while the gesture is active
            transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}

