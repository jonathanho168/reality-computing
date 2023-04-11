using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMaker : MonoBehaviour
{

    public GameObject bunnyPrefab;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)) {
            MakeABunny(1);
        }
    }

    private void OnMouseDown() {
        // Instantiate(bunnyPrefab, transform.position, Quaternion.identity);
        MakeABunny(10);
    }

    private void MakeABunny(int bunnyCount) {

        animator.SetTrigger("Bounce");
        for (int x = 0; x < bunnyCount; x++) {
            // Make a bunny at the place
            Instantiate(bunnyPrefab, transform.position, Quaternion.identity);

            Debug.Log("X = " + (x + 1));
        }
            

            Debug.Log("I, ("  + gameObject.name + ") made a bunny...");
    }
}
