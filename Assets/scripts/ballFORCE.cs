using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ballFORCE : MonoBehaviour
{
    private Rigidbody rb;
    public Text pointtxt;
    //public Text hightxt;

    private float score=00;
    public GameObject dyingsound;
    public GameObject jumpingsound;
    public GameObject gamesound;
    

    // Start is called before the first frame update
    void Start()
    {
        //hightxt.text = highscore.ToString();
        Instantiate(gamesound);
        pointtxt.fontSize = 41;
         rb = GetComponent<Rigidbody>();

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floorcollider" || collision.gameObject.tag == "spikes") {

            
            this.gameObject.SetActive(false);
            
            Instantiate(dyingsound);
             
             
        }


    }
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pointcollider")
        {
            score++;
            pointtxt.text = "Points: " + score.ToString();
            Instantiate(jumpingsound);


        }
    }


    void Update()
    {
       // if (score > highscore) { hightxt.text = score.ToString(); }

        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            rb.AddForce(this.transform.up*150,ForceMode.Force);
        }

    }
}
