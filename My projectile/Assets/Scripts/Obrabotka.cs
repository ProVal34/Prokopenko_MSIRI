using UnityEngine;

public class AnimationObjectReplacer : MonoBehaviour
{
    [Header("Объект для удаления")]
    [SerializeField] private GameObject objectToDestroy;

    [Header("Префаб для спавна")]
    [SerializeField] private GameObject prefabToSpawn;

    [Header("Место появления")]
    [SerializeField] private bool useCustomPosition = false;

    [SerializeField] private Transform spawnPoint;

    public void ReplaceObject()
    {
        if (prefabToSpawn == null)
        {
            Debug.LogWarning("Не назначен prefabToSpawn!");
            return;
        }

        Vector3 spawnPosition;
        Quaternion spawnRotation;

        if (useCustomPosition && spawnPoint != null)
        {
            spawnPosition = spawnPoint.position;
            spawnRotation = spawnPoint.rotation;
        }
        else
        {
            if (objectToDestroy == null)
            {
                Debug.LogWarning("Не назначен objectToDestroy!");
                return;
            }

            spawnPosition = objectToDestroy.transform.position;
            spawnRotation = objectToDestroy.transform.rotation;
        }

        Instantiate(prefabToSpawn, spawnPosition, spawnRotation);

        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}