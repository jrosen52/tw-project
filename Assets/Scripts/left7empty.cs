using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left7empty : MonoBehaviour
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
        if (gameObject.name == "EmptySquare1Red" && collision.gameObject.name == "Square1Red")
        {
            Destroy(bc);
        }
        else if (gameObject.name == "EmptySquar1Yellow" && collision.gameObject.name == "Square1Yellow")
        {
            Destroy(bc);
        }
        else if (gameObject.name == "EmptySquare1Green" && collision.gameObject.name == "Square1Green")
        {
            Destroy(bc);
        }
    }
}
