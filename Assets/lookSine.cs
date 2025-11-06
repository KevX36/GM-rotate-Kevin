using Unity.VisualScripting;
using UnityEngine;

public class lookSine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
        far = transform.position;
        start.z += 5;
        far.z -= 5;
    }
    public GameObject cube;
    private float timer = 0.0f;
    Vector3 start;
    Vector3 far;
    private bool MadeItToFar = false;
    // Update is called once per frame
    void Update()
    {
        Quaternion rotate = transform.rotation;

        rotate.y = Mathf.Sin(Time.time);
        rotate.y /= 2;

        transform.rotation = rotate;

        timer += Time.deltaTime;
        if (timer >= 10)
        {
            timer = 0;
            
        }

        cube.transform.position = Vector3.Slerp(start, far, timer / 10);




    }
}
