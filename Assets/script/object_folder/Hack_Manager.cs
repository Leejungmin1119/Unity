using UnityEngine;

public class Hack_Manager : MonoBehaviour
{

    public static Hack_Manager instance;

    [Header("플레이어 시스템")]
    public GameObject Player_Object;
    public int Player_Level;



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
