using UnityEngine;
using Dreamteck.Splines;

public class CarSplineMover : MonoBehaviour
{
    public SplineComputer spline;  // Spline 경로
    public float speed = 5f;       // 자동차 이동 속도

    private SplineFollower follower;

    void Start()
    {
        follower = gameObject.AddComponent<SplineFollower>();
        follower.spline = spline;
        follower.followSpeed = speed;
        follower.wrapMode = SplineFollower.Wrap.Loop;
    }

    // Editor에서 호출하여 Spline Computer 할당
    public void SetSpline(SplineComputer splineComputer)
    {
        spline = splineComputer;
    }
}
