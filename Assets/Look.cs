using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject cube;
    public bool upT = false;
    public int upSet = -10;
    // Update is called once per frame
    void Update()
    {
        Vector3 cubeLocation = cube.transform.position;
        transform.rotation = Quaternion.LookRotation(cubeLocation);
        if (upT == true)
        {
            Vector3 up = transform.position;
            up.y += upSet;
            transform.rotation = Quaternion.LookRotation(cubeLocation,up);
        }
    }
}
