using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float speed;
    float offset_x;

    // Update is called once per frame
    void Update()
    {
        offset_x += (speed * Time.deltaTime);

        Vector2 offset = new Vector2(offset_x, 0);
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);
    }
}