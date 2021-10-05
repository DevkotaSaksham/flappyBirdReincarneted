using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestroyer : MonoBehaviour
{
    private float life = 1.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life-=Time.deltaTime;
        if (life <= 0) {Destroy(this.gameObject); }
        
    }
}
