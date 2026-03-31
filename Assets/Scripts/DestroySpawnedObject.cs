using UnityEngine;

public class DestroySpawnedObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("KillBox")) Destroy(gameObject);
    }
}
