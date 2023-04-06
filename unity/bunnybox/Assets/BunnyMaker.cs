using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMaker : MonoBehaviour
{

    public GameObject bunnyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)) {
            // Instantiate(bunnyPrefab);

            // transform holds vector3
            Instantiate(bunnyPrefab, transform.position, Quaternion.identity);
        }
    }
}
