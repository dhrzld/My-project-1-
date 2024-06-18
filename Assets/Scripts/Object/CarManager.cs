using UnityEngine;
using Dreamteck.Splines;

public class CarManager : MonoBehaviour
{
    public SplineComputer spline; 
    public GameObject[] carPrefabs; 
    public float spawnInterval = 5f;
    public float speed = 5f; 

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
        int randomIndex = Random.Range(0, carPrefabs.Length);

        GameObject selectedCarPrefab = carPrefabs[randomIndex];

        GameObject newCar = Instantiate(selectedCarPrefab, transform.position, Quaternion.identity);

        CarSplineMover carMover = newCar.AddComponent<CarSplineMover>();
        carMover.spline = spline;
        carMover.speed = speed;
    }
}
