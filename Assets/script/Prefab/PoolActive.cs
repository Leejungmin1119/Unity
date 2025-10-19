using UnityEngine;

public class PoolActive : MonoBehaviour
{
    public GameObject Get(int index)
    {
        
        GameObject select = null;

        // 1. 비활성 오브젝트 찾기
        foreach (GameObject item in poolmanager.instance.pools[index])
        {
            if (!item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                break;

            }

        }
        
        // 2. 비활성 오브젝트가 없으면 신규 오브젝트를 인스턴스화 및 저장
        if(select == null)
        {
            select = Instantiate(poolmanager.instance.prefabs[index], transform);
            poolmanager.instance.pools[index].Add(select);
        }

        // 3. 최종 오브젝트 반환
        return select; 
        
        
    }
}
