using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 5;
    private void Awake()
    {
       //reffrence to our rigid body
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
