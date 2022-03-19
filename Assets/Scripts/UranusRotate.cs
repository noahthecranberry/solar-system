using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusRotate : MonoBehaviour
{
    public int timeScale;
    // Start is called before the first frame update
    void Start()
    {
        timeScale = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f * Time.deltaTime * 3.3333f, 1f * Time.deltaTime * 3.3333f));
        //transform.position = new Vector3(Mathf.Sin(Time.time * timeScale), Mathf.Cos(Time.time * timeScale), 0f);
    }
}
