using UnityEngine;
using Dreamteck.Splines;

public class CarSplineMover : MonoBehaviour
{
    public SplineComputer spline;  
    public float speed = 5f;      

    private SplineFollower follower;

    void Start()
    {
        follower = gameObject.AddComponent<SplineFollower>();
        follower.spline = spline;
        follower.followSpeed = speed;
        follower.wrapMode = SplineFollower.Wrap.Loop;
    }

    public void SetSpline(SplineComputer splineComputer)
    {
        spline = splineComputer;
    }
}
