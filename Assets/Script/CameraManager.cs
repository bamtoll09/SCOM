using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class CameraManager : MonoBehaviour {

    public Boundary boundary;
    public float mouseSensitivity;
    public float zoomSensitivity;
    public float maxZoom;
    public float minZoom;

    Vector3 movement;
    float yValue;
    float moveX, moveY, moveZ;

    void Start()
    {
        moveX = moveY = moveZ = 0f;
    }

    void Update()
    {
        moveY = Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity * Time.deltaTime;

        if (Input.GetMouseButton(1))
        {
            moveX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            moveZ = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        }

        movement = new Vector3(moveX, moveY, moveZ);

        movement = this.transform.position - movement;

        this.transform.position = new Vector3
        (
            Mathf.Clamp(movement.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(movement.y, minZoom, maxZoom),
            Mathf.Clamp(movement.z, boundary.zMin, boundary.zMax)
        );
    }

    // 인터넷 소스
    /*
    public float sensitivityX = 8F;
    public float sensitivityY = 8F;

    float mHdg = 0F;
    float mPitch = 0F;

    void Start()
    {
        // owt? 
    }

    void Update()
    {
        if (!(Input.GetMouseButton(0) || Input.GetMouseButton(1)))
            return;

        float deltaX = Input.GetAxis("Mouse X") * sensitivityX;
        float deltaY = Input.GetAxis("Mouse Y") * sensitivityY;

        if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
        {
            Strafe(deltaX);
            ChangeHeight(deltaY);
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                MoveForwards(deltaY);
                ChangeHeading(deltaX);
            }
            else if (Input.GetMouseButton(1))
            {
                ChangeHeading(deltaX);
                ChangePitch(-deltaY);
            }
        }
    }

    void MoveForwards(float aVal)
    {
        Vector3 fwd = transform.forward;
        fwd.y = 0;
        fwd.Normalize();
        transform.position += aVal * fwd;
    }

    void Strafe(float aVal)
    {
        transform.position += aVal * transform.right;
    }

    void ChangeHeight(float aVal)
    {
        transform.position += aVal * Vector3.up;
    }

    void ChangeHeading(float aVal)
    {
        mHdg += aVal;
        WrapAngle(ref mHdg);
        transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
    }

    void ChangePitch(float aVal)
    {
        mPitch += aVal;
        WrapAngle(ref mPitch);
        transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
    }

    public static void WrapAngle(ref float angle)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
    }
    */

    // 키보드 입력
    /*
    public float speedX;
    public float speedZ;

    // Use this for initialization
    void Start () {
        speedX = 10.0f;
        speedZ = 10.0f;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(
            Input.GetAxis("Horizontal") * speedX * Time.deltaTime,
            0.0f,
            Input.GetAxis("Vertical") * speedZ * Time.deltaTime);
	}
    */
}
