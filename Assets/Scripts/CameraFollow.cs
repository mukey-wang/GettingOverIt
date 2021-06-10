using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        GetComponent<Camera>().transparencySortMode = TransparencySortMode.Orthographic;
    }

    private void FixedUpdate()
    {
        Vector3 moveVec = target.position - GetComponent<Camera>().transform.position;
        moveVec.z = 0;
        GetComponent<Camera>().transform.position += moveVec * Time.fixedDeltaTime * 4.0f;
    }
}
