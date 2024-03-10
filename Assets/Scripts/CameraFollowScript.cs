using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Transform target;
    [Tooltip("value between 0 and 1")]
    [Range(0, 1)]
    public float smoothSpeed = 0.125f; 
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero; 
    [Header("Axis Limitation")]
    public Vector2 xLimit; // X axis limit
    public Vector2 yLimit; // Y axis limit

    void FixedUpdate() {

        Vector3 desiredPosition = target.position + offset; 
        desiredPosition = new Vector3(Mathf.Clamp(desiredPosition.x, xLimit.x, xLimit.y), Mathf.Clamp(desiredPosition.y, yLimit.x, yLimit.y), -10);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
