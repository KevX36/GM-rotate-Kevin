using Unity.VisualScripting;
using UnityEngine;

public class lookSine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject cube;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y +=0.1f;

        

        transform.eulerAngles = rotate;

        Quaternion cubeCurrent = cube.transform.rotation;
        Quaternion cubeTarget = transform.rotation;
        cube.transform.rotation = Quaternion.RotateTowards(cubeCurrent, cubeTarget, 1);
        

        cube.transform.Translate(0, 0, 0.01f);


    }
}
