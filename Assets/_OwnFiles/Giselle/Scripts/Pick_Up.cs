using UnityEngine;

public class Pick_Up : MonoBehaviour
{
    public Transform onHand;
    Rigidbody Cube;

    public void Start()
    {
        Cube = GetComponent<Rigidbody>(); 
    }
    private void OnMouseDown()
    {
        Cube.constraints = RigidbodyConstraints.FreezePosition;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = onHand.transform.position;
        transform.parent = GameObject.Find("Player").transform;

    }

    private void OnMouseUp()
    {
        Cube.constraints = RigidbodyConstraints.None;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        Cube.constraints = RigidbodyConstraints.None;
    }

}
