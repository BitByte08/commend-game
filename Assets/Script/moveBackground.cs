using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour
{
    public GameObject Cloud;
    public GameObject Factory;
    public GameObject Factory2;
    public GameObject Factory3;
    public GameObject Ground;
    public float speed;

    float Cloud_offset;
    float Factory_offset;
    float Factory2_offset;
    float Factory3_offset;
    float Ground_offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cloud_offset += ((speed*0.02F) * Time.deltaTime);
        Factory_offset += ((speed*0.03F) * Time.deltaTime);
        Factory2_offset += ((speed*0.04F) * Time.deltaTime);
        Factory3_offset += ((speed * 0.05F) * Time.deltaTime);
        Ground_offset += ((speed * 3) * Time.deltaTime);


        Vector2 Cloudoffset = new Vector2(Cloud_offset, 0);
        Vector2 Factoryoffset = new Vector2(Factory_offset, 0);
        Vector2 Factory2offset = new Vector2(Factory2_offset, 0);
        Vector2 Factory3offset = new Vector2(Factory3_offset, 0);
        Vector2 Groundoffset = new Vector2(Ground_offset, 0);
        Cloud.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Cloudoffset);
        Factory.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Factoryoffset);
        Factory2.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Factory2offset);
        Factory3.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Factory3offset);
        Ground.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Groundoffset);
    }
}
