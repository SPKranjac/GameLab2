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
        Cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Cube.constraints = RigidbodyConstraints.FreezePosition;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = onHand.transform.position;
        transform.parent = GameObject.Find("Player").transform;

    }

    private void OnMouseUp()
    {
        Cube.transform.localScale = new Vector3(1f, 1f, 1f);
        Cube.constraints = RigidbodyConstraints.None;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        Cube.constraints = RigidbodyConstraints.None;
    }


}
