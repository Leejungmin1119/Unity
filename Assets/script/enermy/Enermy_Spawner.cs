using UnityEngine;

public class Enermy_Spawner : MonoBehaviour
{
    public float sightLevel = 0f;
    public float spawnDistanceOffset;// 카메라를 기준으로 생성거리 값
    public Camera mainCamera;

    // 카메라를 기점으로 랜덤 스폰
    public Vector3 Enermy_Random_Spawn()
    {
        // 1. 카메라위치를 기준으로 얼마나 더 바깥에서 생성할건지 정하기 
        float totalOffset = spawnDistanceOffset;
        
        // 2.  카메라 위치에서 떨어져서 생성되는 거리값 / 카메라 위치 을 통하여 실제 스폰위체에서 얼마나 더 바깥에서 생성할껀지를 비율로 나타냄
        float viewportOffset = totalOffset / mainCamera.orthographicSize; 
        
        // 3. 경계 설정및 각 경계마다 값을 비율로 설정
        int edge = Random.Range(0, 4); // 0: 상, 1: 하, 2: 좌, 3: 우
        Vector3 spawnViewportPoint;


        //check : 1 = 카메라 상단 , 0 카메라 하단 , 0.5 카메라 중단
        if (edge == 0) // 상단 (Top)
        {
            // ex x : 카메라 왼쪽 ~ 오른쪽 / y : 상단 / z : X(2차원 벡터라 없음)
            spawnViewportPoint = new Vector3(Random.Range(0f, 1f), 1f + viewportOffset, 0f); 
        }
        else if (edge == 1) // 하단 (Bottom)
        {
            
            spawnViewportPoint = new Vector3(Random.Range(0f, 1f), 0f - viewportOffset, 0f);
        }
        else if (edge == 2) // 좌측 (Left)
        {
            
            spawnViewportPoint = new Vector3(0f - viewportOffset, Random.Range(0f, 1f), 0f);
        }
        else // 우측 (Right)
        {
            
            spawnViewportPoint = new Vector3(1f + viewportOffset, Random.Range(0f, 1f), 0f);
        }

        // 4. 뷰포트 좌표를 실제 월드 좌표로 변환하여 반환(반환값)
        Vector3 Enermy_World_SpawnPoint = mainCamera.ViewportToWorldPoint(spawnViewportPoint);
        Enermy_World_SpawnPoint.z = 0f; 
        
        return Enermy_World_SpawnPoint;
    }
}
