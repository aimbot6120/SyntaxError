using UnityEngine;
using UnityEngine.Networking;

public class ThirdPersonCamera : NetworkBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 60.0f;

    public Transform LookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = Mathf.Sqrt(38f);
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 1.5f;
    private float sensitivityY = 1.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        if (isLocalPlayer)
        {


            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");
            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }
    }


    private void LateUpdate()
    {
        if (isLocalPlayer)
        {


            Vector3 dir = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
            camTransform.position = LookAt.position + rotation * dir;
            camTransform.LookAt(LookAt.position);

        }
    }
}
