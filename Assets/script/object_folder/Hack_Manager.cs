using UnityEngine;

public class Hack_Manager : MonoBehaviour
{

    public static Hack_Manager instance;

    [Header("플레이어 기본 정보")]
    public float Player_Hp, Player_Speed, Player_Damage;
    Rigidbody2D Player_Object;
    public int Player_Level;
    [Header("저주 상태 변수")]
    public bool Iscruse;
    public int[] Cruse_amount;


    // 싱글턴 인스턴스
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }
}
