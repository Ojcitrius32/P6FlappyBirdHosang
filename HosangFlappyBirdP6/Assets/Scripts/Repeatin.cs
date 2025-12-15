using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Repeatin : MonoBehaviour
{
    private BoxCollider2D groundcollider;
    private float groundHorizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        groundcollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundcollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackround();
        }
    }
    private void RepositionBackround()
    {
        Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
    transform.position = (Vector2) transform.position + groundOffset;
    }
}
