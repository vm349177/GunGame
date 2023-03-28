using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Transform player1;
    public float jump;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            
        {   Vector3 move = new Vector3(0f, jump * Time.deltaTime, 0f);
            player1.transform.position = player1.transform.position + move;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player1.transform.position = player1.transform.position - new Vector3(0f, jump * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player1.transform.position = player1.transform.position - new Vector3( jump * Time.deltaTime, 0f,0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player1.transform.position = player1.transform.position + new Vector3(jump * Time.deltaTime, 0f, 0f);
        }
    }
}
