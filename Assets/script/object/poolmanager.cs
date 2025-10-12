using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class poolmanager : MonoBehaviour
{
    public PoolActive poolActive;
    public static poolmanager instance;
    public GameObject[] prefabs; // 프리팹 배열
    // 프리펩 종류를 담는 배열

    public List<GameObject>[] pools;

    // 풀링된 오브젝트를 저장할 리스트 배열 초기화
    void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];
        for (int index = 0; index < prefabs.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }

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