using UnityEngine;

public class Enermy_Spawner : MonoBehaviour
{
    // 카메라의 둘래를 계산하여 카메라 바깥에서 랜던하게 스폰하게 해줌

    public float sightIncreaseLevel = 0f;
    public float spawnDistanceOffset;// 카메라 바깥에서의 거리
    public Camera mainCamera;
// ... (생략: Start() 및 기타 변수)

    Vector3 CalculateRandomSpawnPosition()
    {
        // 1. 스폰 오프셋 계산 (시야 증가 기능 적용)
        // spawnDistanceOffset (기본 거리) + sightIncreaseLevel (증강으로 인한 추가 거리)
        float totalOffset = spawnDistanceOffset + sightIncreaseLevel;
        
        // Orthographic Size를 이용해 Offset을 뷰포트 비율에 맞게 조정
        // 뷰포트 좌표는 0~1이므로, 1보다 얼마나 더 나가야 하는지 비율로 계산합니다.
        float viewportOffset = totalOffset / mainCamera.orthographicSize; 
        
        // 2. 무작위 경계 및 위치 선택
        int edge = Random.Range(0, 4); // 0: 상, 1: 하, 2: 좌, 3: 우
        Vector3 spawnViewportPoint = Vector3.zero;

        if (edge == 0) // 상단 (Top)
        {
            // Y축: 1 (상단 경계) + offset만큼 바깥
            spawnViewportPoint = new Vector3(Random.Range(0f, 1f), 1f + viewportOffset, 0f);
        }
        else if (edge == 1) // 하단 (Bottom)
        {
            // Y축: 0 (하단 경계) - offset만큼 바깥
            spawnViewportPoint = new Vector3(Random.Range(0f, 1f), 0f - viewportOffset, 0f);
        }
        else if (edge == 2) // 좌측 (Left)
        {
            // X축: 0 (좌측 경계) - offset만큼 바깥
            spawnViewportPoint = new Vector3(0f - viewportOffset, Random.Range(0f, 1f), 0f);
        }
        else // 우측 (Right)
        {
            // X축: 1 (우측 경계) + offset만큼 바깥
            spawnViewportPoint = new Vector3(1f + viewportOffset, Random.Range(0f, 1f), 0f);
        }

        // 3. 뷰포트 좌표를 실제 월드 좌표로 변환하여 반환
        Vector3 spawnWorldPosition = mainCamera.ViewportToWorldPoint(spawnViewportPoint);
        spawnWorldPosition.z = 0f; 
        
        return spawnWorldPosition;
    }
}
