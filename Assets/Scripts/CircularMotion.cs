using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    // User-modifiable
    public float speed = 0.03f;
    public float radius = 50f;
    public bool antiClockwise = false;
    public bool lockX = false;
    public bool lockY = false;

    float movementIncX = 0;
    float movementIncY = 0;

    void FixedUpdate()
    {
        float newx, newy;

        // Compute step
        if(antiClockwise) {
            newx = MqCommon.cosInc(transform.position.y, ref movementIncY, speed, radius);
            newy = MqCommon.sineInc(transform.position.x, ref movementIncX, speed, radius);
        }else{
            newx = MqCommon.sineInc(transform.position.x, ref movementIncX, speed, radius);
            newy = MqCommon.cosInc(transform.position.y, ref movementIncY, speed, radius);
        }

        // Apply reverse direction
        if(antiClockwise) {
            newx = -newx;
            newy = -newy;
        }

        Vector3 movement = new Vector3(
            lockX ? 0 : newx, 
            lockY ? 0 : newy,
            0
        );
        movement *= Time.deltaTime;

        // Absolute position
        transform.position = movement;
    }
}