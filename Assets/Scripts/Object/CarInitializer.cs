using UnityEngine;

public class CarInitializer : MonoBehaviour
{
    void Start()
    {
        TrackManager trackManager = GetComponentInParent<TrackManager>();
        if (trackManager != null)
        {
            Debug.Log("TrackManager found.");
            CarLoop carLoop = GetComponent<CarLoop>();
            if (carLoop != null)
            {
                Debug.Log("CarLoop found. Assigning waypoints.");
                carLoop.waypoints = trackManager.waypoints;
            }
        }
    }
}
