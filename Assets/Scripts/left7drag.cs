using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left7drag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool canMove = true;
    private SpriteRenderer sprite;
    public GameObject level;
    public nextLevel script;
    public float startX, startY;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        level = GameObject.Find("Level");
        script = level.GetComponent<nextLevel>();
        startX = GetComponent<Rigidbody2D>().position.x;
        startY = GetComponent<Rigidbody2D>().position.y;
    }

    void OnMouseDown()
    //void OnMouseOver()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    //void OnMouseOver()
    {
        if (canMove == true)
        {
            script.startClock();
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
            sprite.sortingOrder = 4;
        }
    }

    private void OnTriggerEnter2D(Collider2D EmptySquare)
    {
        float y = EmptySquare.gameObject.GetComponent<Rigidbody2D>().position.y;
        float x = EmptySquare.gameObject.GetComponent<Rigidbody2D>().position.x;
        if ((EmptySquare.gameObject.name == "EmptySquare1Red" && gameObject.tag == "Red") || (EmptySquare.gameObject.name == "EmptySquare1Yellow" && gameObject.tag == "Yellow") || (EmptySquare.gameObject.name == "EmptySquare1Green" && gameObject.tag == "Green"))
        {
            canMove = false;
            sprite.sortingOrder = 5;
            transform.position = new Vector3(x, y, 0);
            script.next();
        }
        else if(EmptySquare.gameObject.tag == "EmptySquare")
        {
            //Debug.Log("hit");
            transform.localPosition = new Vector3(startX, startY, 0);
            canMove = true;
        }
    }
}
