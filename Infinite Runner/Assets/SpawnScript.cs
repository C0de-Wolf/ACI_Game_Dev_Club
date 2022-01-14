using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject Enemy;
    // Start is called before the first frame update

    public float TimeBtwSpawns;
    float Timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= TimeBtwSpawns)
        {
            Timer = 0;
            float y = Random.Range(-4.5f, 4.5f);
            Instantiate(Enemy, new Vector2(transform.position.x, transform.position.y + y), Quaternion.identity);
        }






        
    }
}
