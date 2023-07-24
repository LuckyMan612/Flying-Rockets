using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class meteoryt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(gameObject.transform.forward - new Vector3(0, -180));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
