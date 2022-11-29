using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_sc : MonoBehaviour
{
    Rigidbody _rigidbody;

    public int _scorePlayer1 = 0;
    public int _scorePlayer2 = 0;

    private void OnCollisionExit(Collision collision)
    {
     
        if(collision.collider.tag == "Player2")
        {
            _rigidbody.AddForce(transform.right * -1000f);
        }
        if(collision.collider.tag == "Player1")
        {
            _rigidbody.AddForce(transform.right * 1000f);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0, 0.5f, 0);

        _rigidbody = GetComponent<Rigidbody>();

        _rigidbody.AddForce(transform.right * 1000f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 4.88f)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y, -1 * _rigidbody.velocity.z);
        }
        if (transform.position.z <= -4.88f)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y, -1 * _rigidbody.velocity.z);
        }

        if (transform.position.x >= 10.50f)
        {
            _scorePlayer1++;
            Debug.Log(_scorePlayer1 + " - " + _scorePlayer2);
            
            
        }

        if (transform.position.x <= -10.50f)
        {
            _scorePlayer2++;
            Debug.Log(_scorePlayer1 + " - " + _scorePlayer2);
            
            
        }

        
    }
}
