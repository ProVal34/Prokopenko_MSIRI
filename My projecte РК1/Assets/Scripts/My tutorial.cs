using UnityEngine;
public class Bankuser : MonoBehaviour
{
    [SerializeField] public string bankuser;
    [SerializeField] public int polucheno;
    [SerializeField] public float ostatok;
    public string BankuserName
    {
        get { return bankuser; }
        set { bankuser = value; }
    }
    public int Polucheno
    {
        get { return polucheno; }
        set { polucheno = Mathf.Clamp(value, 0, 100); }
    }
    public float Ostatok
    {
        get { return ostatok; }
        set { ostatok = value; }
    }
    public void Start()
    {
Debug.Log($"Пользователь банка: {bankuser}, снято денег: {polucheno}, остаток средств: {ostatok}");
    }
}