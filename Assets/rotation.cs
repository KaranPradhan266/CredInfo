using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 90f, 0.0f) * Time.deltaTime);
    }
}
