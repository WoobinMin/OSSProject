using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCamera : MonoBehaviour
{

    void Update()
    {
        if (this.transform.position.x > 17.79)
            this.transform.position = new Vector3(0, this.transform.position.y , -10f);

        transform.Translate(5f * Time.deltaTime, 0, 0);

    }
}
