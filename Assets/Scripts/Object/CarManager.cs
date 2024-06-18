using UnityEngine;
using Dreamteck.Splines;

public class CarManager : MonoBehaviour
{
    public SplineComputer spline;  // Spline 경로
    public GameObject[] carPrefabs;  // 다양한 차량 프리팹 배열
    public float spawnInterval = 5f;  // 차량 생성 간격
    public float speed = 5f;  // 자동차 이동 속도

    private float spawnTimer = 0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            SpawnRandomCar();
        }
    }

    void SpawnRandomCar()
    {
        // 랜덤 인덱스 생성
        int randomIndex = Random.Range(0, carPrefabs.Length);

        // 랜덤 차량 프리팹 선택
        GameObject selectedCarPrefab = carPrefabs[randomIndex];

        // 프리팹을 씬에 생성
        GameObject newCar = Instantiate(selectedCarPrefab, transform.position, Quaternion.identity);

        // 생성된 차량에 CarSplineMover 스크립트 추가 및 설정
        CarSplineMover carMover = newCar.AddComponent<CarSplineMover>();
        carMover.spline = spline;
        carMover.speed = speed;
    }
}
