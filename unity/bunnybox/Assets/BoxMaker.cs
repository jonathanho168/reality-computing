using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMaker : MonoBehaviour
{
    public GameObject myBox;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myBox);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
