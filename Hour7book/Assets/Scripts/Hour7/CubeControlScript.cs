using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0f, 0.1f, 0f);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.1f, 0f, 0f);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0f, -0.1f, 0f);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.1f, 0f, 0f);

        if (Input.GetAxis("Mouse Y") > 0)
            transform.Translate(0f, 0.1f, 0f);
        if (Input.GetAxis("Mouse X") < 0)
            transform.Translate(-0.1f, 0f, 0f);
        if (Input.GetAxis("Mouse Y") < 0)
            transform.Translate(0f, -0.1f, 0f);
        if (Input.GetAxis("Mouse X") > 0)
            transform.Translate(0.1f, 0f, 0f);
    }
}


