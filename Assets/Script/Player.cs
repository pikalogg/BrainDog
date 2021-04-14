using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool endGame = false;

    public float speedX = 2;
    public float speedY = 2;
    Transform tran;

    void Awake()
    {
        tran = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            Application.Quit();
            return;
        }

        if (!endGame)
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            tran.position += new Vector3(speedX * h * Time.deltaTime, speedY * v * Time.deltaTime, 0);



        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "khung")
        {

        }
        if (collision.gameObject.tag == "monster")
        {
            endGame = true;
            Debug.Log("dasdasd");
        }
    }


}
