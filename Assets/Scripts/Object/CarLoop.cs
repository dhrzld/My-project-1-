using UnityEngine;

public class CarLoop : MonoBehaviour
{
    public Transform[] waypoints;  
    public float speed = 5f;      
    private int currentWaypointIndex = 0;

    void Update()
    {
        MoveAlongWaypoints();
    }

    void MoveAlongWaypoints()
    {
        if (waypoints.Length == 0)
        {
            Debug.LogWarning("No waypoints assigned.");
            return;
        }

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Debug.Log($"Moving towards waypoint {currentWaypointIndex}: {targetWaypoint.position}");
        Vector3 direction = targetWaypoint.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.LookAt(targetWaypoint);
    }
}
