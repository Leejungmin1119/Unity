using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Hack : MonoBehaviour
{
    public float Player_Hp, Player_Speed, Player_Damage;
    public bool Iscruse;
    public int[] Cruse_amount;
    public static float CurrentAimAngle { get; set; } = 0f;



    void Start()
    {
        Hack_Manager.instance.Player_Object = this.gameObject;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("check");
        // 부딫힌 것이 적이였을경우 막기 실패 => 체력 1감소
        if (collision.gameObject.CompareTag("enermy"))
        {
            Player_Hp--;
            Destroy(collision.gameObject);
        }
    }

}


