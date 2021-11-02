using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    [Tooltip("speed")]
    float speed;
    Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {
        Vec = new Vector3(0, 0, 0);
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.localPosition = Vec;
    }
}
