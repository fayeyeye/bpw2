using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_test : MonoBehaviour
{

    private GameObject player;

    public Animator zonAnimator;

    public Animator globalLightAnimator;

    public Animator windowLights1;
    public Animator windowLights2;
    public Animator windowLights3;
    public Animator windowLights4;
    public Animator windowLights5;
    public Animator windowLights6;
    public Animator windowLights7;
    public Animator windowLights8;
    public Animator windowLights9;

    public Animator spriteLight1;
    public Animator spriteLight2;
    public Animator spriteLight3;
    public Animator spriteLight4;
    public Animator spriteLight5;
    public Animator spriteLight6;
    public Animator spriteLight7;
    public Animator spriteLight8;
    public Animator spriteLight9;

    public Animator reflected1;
    public Animator reflected2;
    public Animator reflected3;
    public Animator reflected4;

    public Animator reflected5;
    public Animator reflected6;

    public Animator pointLight1;
    public Animator pointLight2;
    public Animator pointLight3;
    public Animator pointLight4;

    public Animator kader; 

    public Animator vallendeSter; 
    //public GameObject night; 

    private float playerX;
    private float playerY;
    int bovenaan = 0;
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

        //event > dag/nacht switch 
        if ((playerX >= -1.1 && playerX <= 0.3) && (playerY >= 5.1 && playerY <= 5.4)) {
            bovenaan = 1;

            if (bovenaan > 0 && Input.GetKey("e") && timer <= 0) {

                zonAnimator.SetInteger("switchTriggered", 1);

                globalLightAnimator.SetInteger("switchTriggered", 1);

                windowLights1.SetInteger("switchTriggered", 1);
                windowLights2.SetInteger("switchTriggered", 1);
                windowLights3.SetInteger("switchTriggered", 1);
                windowLights4.SetInteger("switchTriggered", 1);
                windowLights5.SetInteger("switchTriggered", 1);
                windowLights6.SetInteger("switchTriggered", 1);
                windowLights7.SetInteger("switchTriggered", 1);
                windowLights8.SetInteger("switchTriggered", 1);
                windowLights9.SetInteger("switchTriggered", 1);

                spriteLight1.SetInteger("switchTriggered", 1);
                spriteLight2.SetInteger("switchTriggered", 1);
                spriteLight3.SetInteger("switchTriggered", 1);
                spriteLight4.SetInteger("switchTriggered", 1);
                spriteLight5.SetInteger("switchTriggered", 1);
                spriteLight6.SetInteger("switchTriggered", 1);
                spriteLight7.SetInteger("switchTriggered", 1);
                spriteLight8.SetInteger("switchTriggered", 1);
                spriteLight9.SetInteger("switchTriggered", 1);

                reflected1.SetInteger("switchTriggered", 1);
                reflected2.SetInteger("switchTriggered", 1);
                reflected3.SetInteger("switchTriggered", 1);
                reflected4.SetInteger("switchTriggered", 1);

                reflected5.SetInteger("switchTriggered", 1);
                reflected6.SetInteger("switchTriggered", 1);

                pointLight1.SetInteger("switchTriggered", 1);
                pointLight2.SetInteger("switchTriggered", 1);
                pointLight3.SetInteger("switchTriggered", 1);
                pointLight4.SetInteger("switchTriggered", 1);

                kader.SetInteger("switchTriggered", 1);

                Invoke("VallendeSter", 2);

                timer = timerTime;
            }
        }
    }

    void VallendeSter()
    {
        vallendeSter.SetInteger("nacht", (1));
    }
}



