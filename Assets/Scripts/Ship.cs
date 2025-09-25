using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        float xOffset = hor * Time.deltaTime * speed;
        float newXpos = transform.localPosition.x + xOffset;

        float yOffset = ver * Time.deltaTime * speed;
        float newYpos = transform.localPosition.y + yOffset;
        
        transform.localPosition = new Vector3(newXpos, newYpos, transform.localPosition.z);
    }
}
