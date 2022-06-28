using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    public float posOffset;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffSet;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }


        if(Input.GetKey(KeyCode.Space))
        {
            //Vector3 projPosition = new Vector3(gameObject.transform.position.x + posOffset, gameObject.transform.position.y, gameObject.transform.position.z);
            //Instantiate(ProjectilePrefab, projPosition, Quaternion.identity);

            Instantiate(ProjectilePrefab, LaunchOffSet.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude > 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
