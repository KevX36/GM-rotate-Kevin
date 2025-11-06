using UnityEngine;

public class lookSine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotate = transform.rotation;

        rotate.y = Mathf.Sin(Time.time);
        rotate.y /= 2;

        transform.rotation = rotate;






        
    }
}
