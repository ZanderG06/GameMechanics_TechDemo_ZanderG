using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalMenu;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            portalMenu.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            portalMenu.SetActive(false);
        }
    }
}
