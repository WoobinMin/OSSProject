using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    private Vector3 targetPosition;

    public float offSetX;
    public float offSetY;
    public float speed;

    void Start()
    {
    }

    void Update()
    {
        targetPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        targetPosition += new Vector3(offSetX, offSetY,0);
        targetPosition.z = -10f;
         this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, speed * Time.deltaTime);
    }


}