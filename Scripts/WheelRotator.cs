using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotator : MonoBehaviour
{
    

    
    private int _total = 0;
    private bool _isRotating = false;

    public GameObject target;
    private int angle;

    private WaterFloat targetClass;
    // Start is called before the first frame update
    void Start()
    {
        targetClass = target.GetComponent<WaterFloat>();
    }

    // Update is called once per frame
    void Update()
    {
        

        //if (Input.GetKey(KeyCode.D)) transform.rotation *= rotationRight;
        //if (Input.GetKey(KeyCode.A)) transform.rotation *= rotationLeft;

       

        if (Input.GetKeyDown(KeyCode.D))
        {
            //target.GetComponent<WaterFloat>().enabled = false;
            _isRotating = true;
        }
            


        if (Input.GetKeyUp(KeyCode.D))
        {
            //target.GetComponent<WaterFloat>().enabled = true;
            _isRotating = false;
        }
            

        if (Input.GetKey(KeyCode.D))
        {
            angle++;
            transform.Rotate(2, 0, 0);
            targetClass.angle += 0.1f;
            _total++;
        }


        if (!_isRotating && _total > 0)
        {
            transform.Rotate(-2, 0, 0);
            _total--;
        }
            
            
      


    }
}
