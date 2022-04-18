using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    private float m_Input;
    public int health = 3;
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = "Health: " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        m_Input = Input.GetAxisRaw("Vertical");
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);

        }*/

    }
    private void FixedUpdate()
    {   
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, m_Input * speed);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            health--;
            HealthText.text = "Health: " + health.ToString();
            Debug.Log(health);
            if (health == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
