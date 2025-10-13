using UnityEngine;

public class Hack_Manager : MonoBehaviour
{
    // 변수 참조

    public Hack_Aimhelper hack_Aimhelper;
    public Hack hack;

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
        else if(instance != this)
        {
            Destroy(instance);
        }
    }
}
