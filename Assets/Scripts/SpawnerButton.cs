using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    public ObjectSpawner objectSpawner;

    private GameObject buttonOffGO;

    private void Start()
    {
        buttonOffGO = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!objectSpawner.spawnerOn)
            {
                objectSpawner.spawnerOn = true;

                buttonOffGO.SetActive(false);

                Instantiate(objectSpawner.objectToSpawn, objectSpawner.transform.position, Quaternion.identity);
            }
            else if (objectSpawner.spawnerOn)
            {
                objectSpawner.spawnerOn = false;
                buttonOffGO.SetActive(true);
            }
        }
    }
}
