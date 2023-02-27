using UnityEngine;

public class SteeringGear : MonoBehaviour
{
    public float maxAngle = 270;
    public float speed = 100;
    public float lerpSpeed = 0.05f;
    public float lerpAngle = 15;
    public float maxLerpSpeed = 5;

    public Transform rudder;
    public float rudderCoef = 0.15f;

    float angle = 0;

    void Update()
    {
        if (angle > maxAngle - lerpAngle)
        {
            angle = Mathf.Lerp(angle, maxAngle, Time.deltaTime * maxLerpSpeed);
        }
        else if (angle < -maxAngle + lerpAngle)
        {
            angle = Mathf.Lerp(angle, -maxAngle, Time.deltaTime * maxLerpSpeed);
        }
        else
        {
            angle += -Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            angle = Mathf.Clamp(angle, -maxAngle, maxAngle);
        }

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            angle = Mathf.Lerp(angle, 0, Time.deltaTime);
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);

        rudder.rotation = Quaternion.Euler(0, angle * rudderCoef, 0);
    }
}
