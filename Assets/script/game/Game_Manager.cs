using UnityEngine;

public class game_manager : MonoBehaviour
{

    public static game_manager instance;
    public bool IsActive = true;

    [Header("적 스폰 게임 오브젝트")]
    public int AnermyKill;
    public float Enermy_Spawn_Timer;// 적이 스폰되는 시간
    public float Enermy_CoolTime;// 적 스폰 쿨타임
    [Header("게임 타이머")]
    public float Timer;

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
    void FixedUpdate()
    {
        Enermy_Spawn_CoolTimeCheck();
    }

    // 적 오브젝트 생성 타이머
    void Enermy_Spawn_CoolTimeCheck()
    {

        // 1. 적이 생성되야 되는지 시간체크
        if (Enermy_CoolTime >= Enermy_Spawn_Timer)
        {
            // 만약 시간이 됬다면 적 프리펩 오브젝트 활성화
            Enermy_CoolTime = 0f;
            GameObject Enermy_Object = poolmanager.instance.poolActive.Get(poolmanager.instance.Enermy_Prefab);

            Enermy_Object.transform.position = Enermy_Manager.instance.enermy_Spawner.Enermy_Random_Spawn();
            
        }
        // 주기적으로 시간 증가
        Enermy_CoolTime += Time.deltaTime;
    }
}
