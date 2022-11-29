using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_sc : MonoBehaviour
{

    private float _speed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical2");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * _speed * verticalInput);
    
        if (transform.position.z >= 4.283425f)
        {
            transform.position = new Vector3(9.3f, 0, 4.283425f);
        }
        else if (transform.position.z <= -4.283425f)
        {
            transform.position = new Vector3(9.3f, 0, -4.283425f);
        }


    
    }
}
