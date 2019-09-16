using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyMove : MonoBehaviour
{
    Collider2D bc;
    //public GameObject empty;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<Collider2D>();
        ani = GetComponent<Animator>();
        //empty = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "EmptySquare" && collision.gameObject.tag == "Square")
        {
            ani.enabled = false;
            Destroy(bc);
        }
        else if (gameObject.tag == "EmptyCircle" && collision.gameObject.tag == "Circle")
        {
            ani.enabled = false;
            Destroy(bc);
        }
        else if (gameObject.tag == "EmptyRect" && collision.gameObject.tag == "Rect")
        {
            ani.enabled = false;
            Destroy(bc);
        }
    }
}
