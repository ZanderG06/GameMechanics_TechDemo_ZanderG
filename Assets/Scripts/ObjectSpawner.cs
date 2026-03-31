using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public bool spawnerOn = false;

    private void OnTriggerEnter(Collider other)
    {
        if(spawnerOn) Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
