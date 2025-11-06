using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject cube;
    // Update is called once per frame
    void Update()
    {
        Vector3 cubeLocation = cube.transform.position;
        Quaternion.LookRotation(cubeLocation);
    }
}
