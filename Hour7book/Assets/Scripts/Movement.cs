using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _startPosition;
   

    public float speed = 1f;
    public Vector3 Direction1 = Vector3.forward;
    public Vector3 Direction2 = Vector3.left;

    private float _directionIndex;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathField"))
        {
            transform.position = _startPosition;
            _directionIndex = 0;
        }
        //Destroy(gameObject);
            
    }
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startPosition = transform.position;
    }
    private Rigidbody _rigidbody;

    private Vector3 GetDirection()
    {
        if (_directionIndex == 0)
            return Direction1;
        return Direction2;
    }

    private void OnDisable()
    {
        Vector3 velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_directionIndex == 0)
                _directionIndex = 1;
            else
                _directionIndex = 0;
        }
    }

    private void FixedUpdate()
    {
        Vector3 velocity = GetDirection() * speed;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

}
