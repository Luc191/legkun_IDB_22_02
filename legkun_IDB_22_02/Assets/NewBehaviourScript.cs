using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 10f;
    public int c;
    public GameObject cylinder;
    public Text x;
    public GameObject cam;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }
        //if (c <= 0)
        //{
        //    this.gameObject.SetActive(false);
        //}
    }
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void OnCollisionEnter(Collision collision)
    {
        ++c;
        x.text = Convert.ToString(c);
    }

}
