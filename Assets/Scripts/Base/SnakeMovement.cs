using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    //CODE FROM https://www.youtube.com/watch?v=0vFucqblH-g

    private Vector2Int gridMoveDirection;
    private Vector2Int gridPosition;

    public TMP_Text fruitCounter;
    public int collected = 0;

    private void Awake()
    {
        gridPosition = new Vector2Int(0, 0);
        gridMoveDirection = new Vector2Int(1, 0);

    }


    private void Start()
    {
        fruitCounter.text = "Score:" + collected;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gridPosition.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gridPosition.y -= 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gridPosition.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gridPosition.x += 1;
        }

        transform.position = new Vector3(gridPosition.x, gridPosition.y);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            Destroy(gameObject);
            collected++;
            fruitCounter.text = "Score:" + collected;
        }
    }
}