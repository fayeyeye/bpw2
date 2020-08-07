using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_test : MonoBehaviour
{

    private GameObject player;
    private float playerX;
    private float playerY;
    public float timerTime;
    float timer; 

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;
        if (Input.GetKey("space") && timer <= 0) {

            Debug.Log("x is" + playerX + "y is" + playerY);
            timer = timerTime;
        }
    }
}
