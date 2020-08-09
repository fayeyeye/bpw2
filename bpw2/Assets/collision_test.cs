using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject catText;
    public GameObject bellText;
    public GameObject boatText;
    //public GameObject night; 

    private float playerX;
    private float playerY;
    int bovenaan = 0;
    int onderaan = 0;
    int alBovenGeweest = 0; 

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

        Debug.Log("x is" + playerX + "y is" + playerY);

        //event > dag/nacht switch 
        if ((playerX >= -1.1 && playerX <= 0.3) && (playerY >= 5.1 && playerY <= 5.4))
        {
            bovenaan = 1;
            bellText.SetActive(true);

            if (bovenaan > 0 && Input.GetKey("e") && timer <= 0)
            {

                zonAnimator.SetInteger("switchTriggered", 1);
                zonAnimator.SetInteger("switch2Triggered", 0);

                globalLightAnimator.SetInteger("switchTriggered", 1);
                globalLightAnimator.SetInteger("switch2Triggered", 0);

                windowLights1.SetInteger("switchTriggered", 1);
                windowLights2.SetInteger("switchTriggered", 1);
                windowLights3.SetInteger("switchTriggered", 1);
                windowLights4.SetInteger("switchTriggered", 1);
                windowLights5.SetInteger("switchTriggered", 1);
                windowLights6.SetInteger("switchTriggered", 1);
                windowLights7.SetInteger("switchTriggered", 1);
                windowLights8.SetInteger("switchTriggered", 1);
                windowLights9.SetInteger("switchTriggered", 1);

                windowLights1.SetInteger("switch2Triggered", 0);
                windowLights2.SetInteger("switch2Triggered", 0);
                windowLights3.SetInteger("switch2Triggered", 0);
                windowLights4.SetInteger("switch2Triggered", 0);
                windowLights5.SetInteger("switch2Triggered", 0);
                windowLights6.SetInteger("switch2Triggered", 0);
                windowLights7.SetInteger("switch2Triggered", 0);
                windowLights8.SetInteger("switch2Triggered", 0);
                windowLights9.SetInteger("switch2Triggered", 0);

                spriteLight1.SetInteger("switchTriggered", 1);
                spriteLight2.SetInteger("switchTriggered", 1);
                spriteLight3.SetInteger("switchTriggered", 1);
                spriteLight4.SetInteger("switchTriggered", 1);
                spriteLight5.SetInteger("switchTriggered", 1);
                spriteLight6.SetInteger("switchTriggered", 1);
                spriteLight7.SetInteger("switchTriggered", 1);
                spriteLight8.SetInteger("switchTriggered", 1);
                spriteLight9.SetInteger("switchTriggered", 1);

                spriteLight1.SetInteger("switch2Triggered", 0);
                spriteLight2.SetInteger("switch2Triggered", 0);
                spriteLight3.SetInteger("switch2Triggered", 0);
                spriteLight4.SetInteger("switch2Triggered", 0);
                spriteLight5.SetInteger("switch2Triggered", 0);
                spriteLight6.SetInteger("switch2Triggered", 0);
                spriteLight7.SetInteger("switch2Triggered", 0);
                spriteLight8.SetInteger("switch2Triggered", 0);
                spriteLight9.SetInteger("switch2Triggered", 0);

                reflected1.SetInteger("switchTriggered", 1);
                reflected2.SetInteger("switchTriggered", 1);
                reflected3.SetInteger("switchTriggered", 1);
                reflected4.SetInteger("switchTriggered", 1);

                reflected1.SetInteger("switch2Triggered", 0);
                reflected2.SetInteger("switch2Triggered", 0);
                reflected3.SetInteger("switch2Triggered", 0);
                reflected4.SetInteger("switch2Triggered", 0);

                reflected5.SetInteger("switchTriggered", 1);
                reflected6.SetInteger("switchTriggered", 1);

                reflected5.SetInteger("switch2Triggered", 0);
                reflected6.SetInteger("switch2Triggered", 0);

                pointLight1.SetInteger("switchTriggered", 1);
                pointLight2.SetInteger("switchTriggered", 1);
                pointLight3.SetInteger("switchTriggered", 1);
                pointLight4.SetInteger("switchTriggered", 1);

                pointLight1.SetInteger("switch2Triggered", 0);
                pointLight2.SetInteger("switch2Triggered", 0);
                pointLight3.SetInteger("switch2Triggered", 0);
                pointLight4.SetInteger("switch2Triggered", 0);

                kader.SetInteger("switchTriggered", 1);
                kader.SetInteger("switch2Triggered", 0);

                Invoke("VallendeSter", 2);
                vallendeSter.SetInteger("dag", 0);

                timer = timerTime;
                alBovenGeweest = 1;
            }
        }

        else
        {
            bellText.SetActive(false);
        }

        // terugschakeling dag -> speler bij kat
        if ((playerX >= 1.3 && playerX <= 1.8) && (playerY >= -1.7 && playerY <= -1.2))
        {
            onderaan = 1;
            catText.SetActive(true);


            if (onderaan > 0 && Input.GetKey("e") && timer <= 0)
            {
                player.GetComponent<AudioSource>().enabled = true;
                Invoke("miauw", 2);
                Debug.Log("onderaan");

                globalLightAnimator.SetInteger("switch2Triggered", 1);
                globalLightAnimator.SetInteger("switchTriggered", 0);

                zonAnimator.SetInteger("switchTriggered", 0);
                zonAnimator.SetInteger("switch2Triggered", 1);

                windowLights1.SetInteger("switch2Triggered", 1);
                windowLights2.SetInteger("switch2Triggered", 1);
                windowLights3.SetInteger("switch2Triggered", 1);
                windowLights4.SetInteger("switch2Triggered", 1);
                windowLights5.SetInteger("switch2Triggered", 1);
                windowLights6.SetInteger("switch2Triggered", 1);
                windowLights7.SetInteger("switch2Triggered", 1);
                windowLights8.SetInteger("switch2Triggered", 1);
                windowLights9.SetInteger("switch2Triggered", 1);

                windowLights1.SetInteger("switchTriggered", 0);
                windowLights2.SetInteger("switchTriggered", 0);
                windowLights3.SetInteger("switchTriggered", 0);
                windowLights4.SetInteger("switchTriggered", 0);
                windowLights5.SetInteger("switchTriggered", 0);
                windowLights6.SetInteger("switchTriggered", 0);
                windowLights7.SetInteger("switchTriggered", 0);
                windowLights8.SetInteger("switchTriggered", 0);
                windowLights9.SetInteger("switchTriggered", 0);

                spriteLight1.SetInteger("switch2Triggered", 1);
                spriteLight2.SetInteger("switch2Triggered", 1);
                spriteLight3.SetInteger("switch2Triggered", 1);
                spriteLight4.SetInteger("switch2Triggered", 1);
                spriteLight5.SetInteger("switch2Triggered", 1);
                spriteLight6.SetInteger("switch2Triggered", 1);
                spriteLight7.SetInteger("switch2Triggered", 1);
                spriteLight8.SetInteger("switch2Triggered", 1);
                spriteLight9.SetInteger("switch2Triggered", 1);

                spriteLight1.SetInteger("switchTriggered", 0);
                spriteLight2.SetInteger("switchTriggered", 0);
                spriteLight3.SetInteger("switchTriggered", 0);
                spriteLight4.SetInteger("switchTriggered", 0);
                spriteLight5.SetInteger("switchTriggered", 0);
                spriteLight6.SetInteger("switchTriggered", 0);
                spriteLight7.SetInteger("switchTriggered", 0);
                spriteLight8.SetInteger("switchTriggered", 0);
                spriteLight9.SetInteger("switchTriggered", 0);

                reflected1.SetInteger("switchTriggered", 0);
                reflected2.SetInteger("switchTriggered", 0);
                reflected3.SetInteger("switchTriggered", 0);
                reflected4.SetInteger("switchTriggered", 0);

                reflected1.SetInteger("switch2Triggered", 1);
                reflected2.SetInteger("switch2Triggered", 1);
                reflected3.SetInteger("switch2Triggered", 1);
                reflected4.SetInteger("switch2Triggered", 1);

                reflected5.SetInteger("switchTriggered", 0);
                reflected6.SetInteger("switchTriggered", 0);

                reflected5.SetInteger("switch2Triggered", 1);
                reflected6.SetInteger("switch2Triggered", 1);

                pointLight1.SetInteger("switchTriggered", 0);
                pointLight2.SetInteger("switchTriggered", 0);
                pointLight3.SetInteger("switchTriggered", 0);
                pointLight4.SetInteger("switchTriggered", 0);

                pointLight1.SetInteger("switch2Triggered", 1);
                pointLight2.SetInteger("switch2Triggered", 1);
                pointLight3.SetInteger("switch2Triggered", 1);
                pointLight4.SetInteger("switch2Triggered", 1);

                kader.SetInteger("switchTriggered", 0);
                kader.SetInteger("switch2Triggered", 2);

                vallendeSter.SetInteger("nacht", 0);
                vallendeSter.SetInteger("dag", 1);

            }
        }

        else
        {
            catText.SetActive(false);
        }

        if ((playerX >= 0.4 && playerX <= 1.1) && (playerY >= -4.7 && playerY <= -4.0 && alBovenGeweest > 0))
        {
            boatText.SetActive(true);

            if (Input.GetKey("e"))
            {
               
                zonAnimator.SetInteger("switchTriggered", 1);
                globalLightAnimator.SetInteger("GameEnd", 1);
                Invoke("gameEnd", 2);
                boatText.SetActive(false);
                alBovenGeweest = 0;
            }
        }

        else
        {
            boatText.SetActive(false);
        }
    }

    void miauw()
    {
        player.GetComponent<AudioSource>().enabled = false;
    }

    void VallendeSter()
    {
        vallendeSter.SetInteger("nacht", (1));
    }

    void gameEnd()
    {
        SceneManager.LoadScene("start");
    }
}



