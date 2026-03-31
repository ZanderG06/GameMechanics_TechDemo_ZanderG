using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
