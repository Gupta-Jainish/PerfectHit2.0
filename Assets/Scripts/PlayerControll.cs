using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float Velo;
    [SerializeField] float RightVal;

    void Start()
    {
        Rigi();
        Forward();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Left();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Right();
        }
    }

    public void Rigi()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Forward()
    {
        rb.velocity = new Vector3(0, 0, Velo);
    }

    public void Left()
    {
        rb.transform.position -= transform.right * Time.deltaTime * RightVal;
    }

    public void Right()
    {
        rb.transform.position += transform.right * Time.deltaTime * RightVal;
    }
}
