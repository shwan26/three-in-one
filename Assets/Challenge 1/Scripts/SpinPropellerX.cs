using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float spinSpeed = 1000f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}
