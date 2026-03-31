using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    public ObjectSpawner objectSpawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!objectSpawner.spawnerOn)
            {
                objectSpawner.spawnerOn = true;

                Instantiate(objectSpawner.objectToSpawn, objectSpawner.transform.position, Quaternion.identity);
            }
            else if (objectSpawner.spawnerOn)
            {
                objectSpawner.spawnerOn = false;
            }
        }
    }
}
