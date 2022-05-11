using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningCube : MonoBehaviour
{
    Transform[] piece = new Transform[26];
    // Start is called before the first frame update
    void Start()
    {
        Transform[] allchildren = gameObject.GetComponentsInChildren<Transform>();
        int count = 0;
        for(int i = 0; i < allchildren.Length; i++)
        {
            if (!allchildren[i].name.ToLower().Replace(" ", "").Contains("sticker") && i > 0)
            {
                piece[count] = allchildren[i];
                count++;
            }            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
