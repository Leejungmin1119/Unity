using UnityEngine;

public class Enermy_Manager : MonoBehaviour
{
    [Header("스크립트 참조 변수")]
    public Enermy enermy;
    public Enermy_Spawner enermy_Spawner;

    public static Enermy_Manager instance;

    [Header("적 공통 정보")]
    public GameObject Kill_Target;
    
    void Awake()
    {
        if (!instance)
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
