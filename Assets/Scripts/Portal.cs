using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject otherPortal;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = otherPortal.transform.position;
        }
    }
}
