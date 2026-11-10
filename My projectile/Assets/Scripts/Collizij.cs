using UnityEngine;

public class Collizij : MonoBehaviour
{
    public GameObject kub;
    void Start()
    {
        gameObject.name = "kub";
    }
    void Update()
    {
    }  
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "Сфера" )
        {
        print("Сфера столкнулась");
        Destroy(gameObject);
         // GameObject c = Instantiate(kub, kub.transform.position,kub.transform.rotation);
          Instantiate(kub, new Vector3(4, 1, 0), Quaternion.identity);
          Instantiate(kub, new Vector3(2, 1, 0), Quaternion.identity);
          Instantiate(kub, new Vector3(-2, 1, 0), Quaternion.identity);
          gameObject.GetComponent<Collizij>().enabled = false;
        }
    }
} 
