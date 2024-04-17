using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //<access modifier, var type, var name>

    public int healthPoints;
    public int constitution;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        constitution = 50;
        
    }

    // Update is called once per frame
    void Update()
    {
        healthPoints = constitution * 6;
    }
}
