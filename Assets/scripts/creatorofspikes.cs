using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class creatorofspikes : MonoBehaviour
{
    public GameObject mover;
    private float rate = 0.9f;
    private float starttimer = 0f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
       // mover= GameObject.FindGameObjectWithTag("mover");
    }

    IEnumerator waitt()
    {

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void Update()
    {
        if (ball.activeSelf==false) { StartCoroutine(waitt()); }

        starttimer -= Time.deltaTime;
        if (starttimer <= 0)
        {
            float ypos = Random.Range(1,4);

            Instantiate(mover, new Vector3(1, ypos,15), transform.rotation);
            starttimer = rate;
        }
        
    }
}
