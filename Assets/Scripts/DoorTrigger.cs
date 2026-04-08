using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public DoorController doorController;

    private void OnTriggerEnter(Collider other)
    {
        doorController.isOpen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        doorController.isOpen = false;
    }
}
