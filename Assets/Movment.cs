using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{


    [SerializeField]
    Rigidbody2D rb;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(5f, 5f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}