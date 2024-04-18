using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMotion)
        {
        transform.Translate(Vector3.right * motionMagnitude * Mathf.Cos(Time.timeSinceLevelLoad) * Time.deltaTime);
        }
    }
}
