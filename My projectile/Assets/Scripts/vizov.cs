using UnityEngine;
public class Manager : MonoBehaviour
{
[SerializeField] private Bankuser bankuser;
private void Start()
{
Debug.Log($"Имя: {bankuser.BankuserName}");
Debug.Log($"Получено: {bankuser.Polucheno}");
Debug.Log($"Остаток: {bankuser.Ostatok}");
}
}