using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour
{
    Collider2D bc;
    //public GameObject empty;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<Collider2D>();
        //empty = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "EmptySquare" && collision.gameObject.tag == "Square")
        {
            Destroy(bc);
        }
        else if(gameObject.tag == "EmptyCircle" && collision.gameObject.tag == "Circle")
        {
            Destroy(bc);
        }
        else if(gameObject.tag == "EmptyRect" && collision.gameObject.tag == "Rect")
        {
            Destroy(bc);
        }
    }
}