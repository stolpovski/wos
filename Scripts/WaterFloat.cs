using UnityEngine;

public class WaterFloat : MonoBehaviour
{
    public Vector3 MovingDistances = new Vector3(0.002f, 0.001f, 0f);     //up and down distance of the wave
    public float speed = 1f;                                              //the speed of up and down

    public Vector3 WaveRotations;                                         //object side rotations
    public float WaveRotationsSpeed = 0.3f;                               //speed of rotations

    public Vector3 AxisOffsetSpeed;                                       //speed of moving object along an axis

    Transform actualPos;                                                  //save the actual transform

    public Quaternion originRotation;
    public Quaternion rotationY;
    public Quaternion rotationX;
    public float angle;

    void Start()
    {
        originRotation = transform.rotation;
        
    }

    
    void Update () 
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        //angle++;

        rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        rotationX = Quaternion.AngleAxis(originRotation.x + WaveRotations.x * Mathf.Sin(Time.time * WaveRotationsSpeed), Vector3.right);
        Quaternion rotationZ = Quaternion.AngleAxis(originRotation.z + WaveRotations.z * Mathf.Sin(Time.time * WaveRotationsSpeed), Vector3.forward);


        //transform.rotation = Quaternion.Euler(
        //actualPos.rotation.x + WaveRotations.x * Mathf.Sin(Time.time * WaveRotationsSpeed),
        //transform.rotation.y,
        //actualPos.rotation.z + WaveRotations.z * Mathf.Sin(Time.time * WaveRotationsSpeed)
        //);

        //transform.rotation = Quaternion.AngleAxis(actualPos.rotation.x + WaveRotations.x * Mathf.Sin(Time.time * WaveRotationsSpeed), Vector3.right);
        //transform.rotation = Quaternion.AngleAxis(1, Vector3.up);


        transform.rotation = originRotation * rotationZ * rotationY * rotationX;




    }
}
