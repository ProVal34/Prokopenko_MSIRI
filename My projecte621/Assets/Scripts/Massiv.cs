using UnityEngine;

public class Massiv : MonoBehaviour
{
    public GameObject kub;

    public float[] param = { 1, 2, 3, 4 };

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Сфера")
        {
            print("Сфера столкнулась");

            float distance = param[0];
            int count = (int)param[1];
            float startX = param[2];
            float startY = param[3];

            for (int i = 0; i < count; i++)
            {
                Vector3 pos = new Vector3
                (
                    startX + i * distance,
                    startY,
                    0
                );

                Instantiate(kub, pos, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}