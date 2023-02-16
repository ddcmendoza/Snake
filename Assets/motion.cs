using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody.gravityScale = 0;
        myRigidbody.velocity.Set(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(z, 0, 0);
        Vector3 rotation = new Vector3(0, 0, -x*z);
        transform.Translate(movement * 2 * Time.deltaTime);
        transform.Rotate(rotation * 30 * Time.deltaTime);
    }
}
