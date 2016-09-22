using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speedX;
    public float speedY;

    float beforeX, beforeY, afterX, afterY;

    // Use this for initialization
    void Start()
    {
        speedX = 3.0f;
        speedY = 3.0f;
        beforeX = beforeY = afterX = afterY = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        beforeX = this.transform.position.x;
        beforeY = this.transform.position.y;

        this.transform.Translate(
            Input.GetAxis("Horizontal") * speedX * Time.deltaTime,
            Input.GetAxis("Vertical") * speedY * Time.deltaTime,
            0.0f);

        afterX = this.transform.position.x;
        afterY = this.transform.position.y;

        Debug.Log(Distance(beforeX, beforeY, afterX, afterY));
    }
    
    float Distance(float x1, float y1, float x2, float y2)
    {
        return Mathf.Sqrt(Mathf.Pow((x1 - x2), 2.0f) + Mathf.Pow((y1 - y2), 2.0f));
    }
}
