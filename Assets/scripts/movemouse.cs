using UnityEngine;
using UnityEngine.PlayerLoop;

public class movemouse : MonoBehaviour
{
    public float timeForOneCircle = 4f;
    public float radius = 5f;
    private float angle = 0;
    public float portalAngle = 0;
    public float force;
    private CharacterController controller;
    public Vector3 directionForPortal;
    bool teleport;
    Vector3 tpposition;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        angle += (2 * Mathf.PI * (1 / timeForOneCircle)) * Time.deltaTime;
        portalAngle = angle;
        Vector3 movement = new Vector3(Mathf.Cos(angle) *
radius, transform.localPosition.y, Mathf.Sin(angle) * radius);
        Vector3 tangent = Vector3.Cross(movement, Vector3.up).normalized;
        transform.forward = tangent;
        transform.right = -transform.forward;
        controller.SimpleMove(tangent * force);
        directionForPortal = tangent;
        if(teleport)
        {
            transform.position = tpposition;
            teleport = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enter"))
        {
            Debug.Log("teleport");
            tpposition = new
Vector3(transform.position.x,
other.transform.Find("Exit").transform.position.y,
transform.position.z);
            teleport= true;
        }
        if(other.CompareTag("cheese"))
        {
            Actions.gamelost();
            Debug.Log("cheese touched");
        }
    }
   
}
