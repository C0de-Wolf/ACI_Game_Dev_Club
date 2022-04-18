using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject Enemy;
    // Start is called before the first frame update

    public float TimeBtwSpawns =5f;
    float Timer;
    float CountTimeForDifficulty;
    float SecondForIncreasingHardness=3; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        //Debug.Log(Timer);
        if (Timer >= TimeBtwSpawns)
        {
            Timer = 0;
            float y = Random.Range(-4.5f, 4.5f);
            float angle = Random.Range(-180, 180);
            Instantiate(Enemy, new Vector2(transform.position.x, transform.position.y + y), Quaternion.Euler(0,0, angle));
            Enemy.tag = "Enemy";
        }

        CountTimeForDifficulty += Time.deltaTime;
        if (CountTimeForDifficulty >= SecondForIncreasingHardness)
        {
            CountTimeForDifficulty = 0;
            if (TimeBtwSpawns >= 2.5f)
            {
                TimeBtwSpawns -= 0.5f;
            }
        }




        
    }
}
