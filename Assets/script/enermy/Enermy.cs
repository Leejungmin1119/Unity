using Unity.VisualScripting;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public float Enermy_Hp;
    public float Enermy_Speed;
    public float Enermy_Damage;
    public GameObject Enermy_Object;

    void Awake()
    {
        Enermy_Object = this.gameObject;
    }
    public Vector3 Target_direction;
    void FixedUpdate()
    {
        // **********|||타겟팅|||********* //

        // 1. 가야될 방향 벡터 구한후 크기 1로 정규화
        Target_direction =  Enermy_Manager.instance.Kill_Target.transform.position - Enermy_Object.transform.position;

        Vector2 Speed = Target_direction.normalized * Enermy_Speed;

        // 2. 벡터 * 속도 해서 오브젝트에 적용
        Enermy_Object.GetComponent<Rigidbody2D>().linearVelocity = Speed;

    }


}
