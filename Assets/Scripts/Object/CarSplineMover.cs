using UnityEngine;
using Dreamteck.Splines;

public class CarSplineMover : MonoBehaviour
{
    public SplineComputer spline;  // Spline ���
    public float speed = 5f;       // �ڵ��� �̵� �ӵ�

    private SplineFollower follower;

    void Start()
    {
        follower = gameObject.AddComponent<SplineFollower>();
        follower.spline = spline;
        follower.followSpeed = speed;
        follower.wrapMode = SplineFollower.Wrap.Loop;
    }

    // Editor���� ȣ���Ͽ� Spline Computer �Ҵ�
    public void SetSpline(SplineComputer splineComputer)
    {
        spline = splineComputer;
    }
}
