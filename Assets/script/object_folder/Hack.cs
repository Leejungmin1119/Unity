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

    void Update()
    {
    }
}


