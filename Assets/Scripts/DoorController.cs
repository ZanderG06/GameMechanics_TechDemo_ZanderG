using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openRotation, closeRotation, rotationSpeed;
    public bool isOpen;

    void Update()
    {
        Vector3 currentRotation = transform.localEulerAngles;

        if (isOpen && currentRotation.y < openRotation) transform.localEulerAngles = Vector3.Lerp(currentRotation, new Vector3(currentRotation.x, openRotation, currentRotation.z), rotationSpeed * Time.deltaTime);
        else if (currentRotation.y > closeRotation) transform.localEulerAngles = Vector3.Lerp(currentRotation, new Vector3(currentRotation.x, closeRotation, currentRotation.z), rotationSpeed * Time.deltaTime);
    }
}
