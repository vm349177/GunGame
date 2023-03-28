using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Collider2D body;
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
        if (Input.GetKey(KeyCode.UpArrow))

        {
            Vector3 move = new Vector3(0f, jump * Time.deltaTime, 0f);
            player1.transform.position = player1.transform.position + move;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player1.transform.position = player1.transform.position - new Vector3(0f, jump * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player1.transform.position = player1.transform.position - new Vector3(jump * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player1.transform.position = player1.transform.position + new Vector3(jump * Time.deltaTime, 0f, 0f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if ((collision.gameObject.CompareTag("Floor")) && Input.GetKey(KeyCode.DownArrow))
        {   
            body.isTrigger = true;
        }
    }
}

