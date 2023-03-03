using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public PlayerHealth ph;

    // Start is called before the first frame update
    void Start()
    {
        ph = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }
}
