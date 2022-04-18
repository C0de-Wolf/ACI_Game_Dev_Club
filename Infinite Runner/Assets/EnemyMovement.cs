using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        angle = Random.Range(-0.5f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left*speed;
        gameObject.transform.Rotate(new Vector3(0, 0, angle));
    }


}
