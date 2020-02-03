using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canPressSpace = true;

    private void Start()
    {
        InvokeRepeating("setCanPressSpace", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canPressSpace)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canPressSpace = false;
        }
    }

    private void setCanPressSpace()
    {
        canPressSpace = true;
    }
}
