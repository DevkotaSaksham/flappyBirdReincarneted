using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void loadgame() {

        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}