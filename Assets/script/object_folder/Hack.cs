using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Hack : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hack_Manager.instance.Player_Object = GetComponent<Rigidbody2D>();
    }

    // 공격 키 (예: Spacebar)를 눌렀을 때 발사
    void Update()
    {
        // 1. 공격 키 입력 확인 (예: 스페이스바)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 2. 현재 입력된 방향키 값을 가져옵니다.
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
        }
    }
}

