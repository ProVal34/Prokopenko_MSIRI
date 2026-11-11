using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    public CncJsonController cncController;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (cncController != null)
        {
            cncController.StopStream();
        }
    }
}