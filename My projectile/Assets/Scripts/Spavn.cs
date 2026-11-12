using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Префаб для создания")]
    [SerializeField] private GameObject prefabToSpawn;

   [Header("Точка появления")]
    [SerializeField] private Vector3 spawnPosition;

    public void SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            Instantiate( prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}