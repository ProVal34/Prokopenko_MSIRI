using UnityEngine;

public class Ogranich : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {transform.localPosition = new Vector3(
    Mathf.Clamp(transform.localPosition.x, -2f, 2f),
    transform.localPosition.y,
    Mathf.Clamp(transform.localPosition.z, -1f, 3f)
);
    void Update()
    {
        
    }
}
