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
            MakeABunny();
        }
    }

    private void OnMouseDown() {
        // Instantiate(bunnyPrefab, transform.position, Quaternion.identity);
        MakeABunny();
    }

    private void MakeABunny() {
                    // Instantiate(bunnyPrefab);

            // Make a bunny at the place
            Instantiate(bunnyPrefab, transform.position, Quaternion.identity);

            Debug.Log("I made a bunny...");
    }
}
