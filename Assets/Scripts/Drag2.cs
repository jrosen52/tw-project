using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CircleCollider2D))]

public class Drag2 : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool canMove = true;
    private SpriteRenderer sprite;
    public GameObject level;
    public nextLevel script;
    Scene m_Scene;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        level = GameObject.Find("Level");
        script = level.GetComponent<nextLevel>();
    }

    void OnMouseDown()   //void OnMouseOver()
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

    private void OnTriggerEnter2D(Collider2D EmptyCircle)
    {
        float y = EmptyCircle.gameObject.GetComponent<Rigidbody2D>().position.y;
        float x = EmptyCircle.gameObject.GetComponent<Rigidbody2D>().position.x;

        if (EmptyCircle.gameObject.tag == "EmptyCircle")
        {
            canMove = false;
            sprite.sortingOrder = 3;
            transform.position = new Vector3(x, y, 0);
            script.next();
        }
        else
        {
            canMove = true;
        }
    }
}
