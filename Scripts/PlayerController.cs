using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private GameMaster gm;

    public GameObject player;
    private Rigidbody2D rb;
    public static bool charge = true;
    public float speed = 4.0f;
    SpriteRenderer sprite;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
        sprite = GetComponent<SpriteRenderer>();

        //GM
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
    }

    void Update()
    {
        if (charge == true)
        {
            sprite.color = new Color(0.4f, 0.5f, 0.8f, 1);
        }

        else if (charge == false)
        {
            sprite.color = new Color(1, 0, 0, 1);
        }

        if (charge == true)
        {
            sprite.color = new Color(0.4f, 0.5f, 0.8f, 1);
        }

        else if (charge == false)
        {
            sprite.color = new Color(1, 0, 0, 1);
        }

        if (Input.GetKey(KeyCode.UpArrow) && (charge == true))
        {
            rb.velocity = new Vector2(0.0f, speed);
            //charge = false;
            Debug.Log ("Up");
        }

        if (Input.GetKey(KeyCode.DownArrow) && (charge == true))
        {
            rb.velocity = new Vector2(0.0f, -speed);
            //charge = false;
            Debug.Log("Down");
        }

        if (Input.GetKey(KeyCode.LeftArrow) && (charge == true))
        {
            rb.velocity = new Vector2(-speed, 0.0f);
            //charge = false;
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.RightArrow) && (charge == true))
        {
            rb.velocity = new Vector2(speed, 0.0f);
            //charge = false;
            Debug.Log("Right");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Debug.Log("First check");
            player.transform.parent = other.gameObject.transform;
            Debug.Log("Second check");

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            player.transform.parent = null;
        }
    }
}