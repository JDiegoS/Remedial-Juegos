using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public GameObject prefab;
    public float xPos;
    public float xPos2;
    private GameObject p;
    private GameObject d;
    


    // Start is called before the first frame update
    void Start()
    {
        p = Instantiate(prefab, new Vector2(xPos, Random.Range(-1f, 2.4f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (p.transform.position.x < -5.5)
        {
            d = p;
            p = Instantiate(prefab, new Vector2(xPos2, Random.Range(-1f, 2.4f)), Quaternion.identity);
            Destroy(d);
        }
    }
}
