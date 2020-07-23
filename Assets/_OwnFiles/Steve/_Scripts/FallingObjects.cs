using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    Rigidbody rb;

    public GameObject block;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
            Debug.Log(" LOOK OUT!! ");
            //BlockDestroy();
            Debug.Log(" activating destroy box ");

        }
    }

    void OnTriggerEnter(Collider collider)
    {
         if (collider.gameObject.tag == "Pit")
        {
            Debug.Log(" Bridge Collapsed");
            Destroy(block);  
        }

    }

    //IEnumerator BlockDestroy()
    //{
    //    yield return new WaitForSeconds(3);
    //    block.gameObject.SetActive(false);
    //    Debug.Log(" Destroying block in 3... 2... 1...");
    //}

}
