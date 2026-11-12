using UnityEngine;

public class TeleportZone : MonoBehaviour
{
    [Header("Объект для телепортации")]
    [SerializeField] private GameObject targetObject;

    [Header("Координаты телепортации")]
    [SerializeField] private Vector3 teleportPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleportable"))
        {
            other.transform.position = teleportPosition;
        }
    }
}