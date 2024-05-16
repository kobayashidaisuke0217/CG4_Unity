using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerPos = player.transform.position;
        var pos = transform.position;
        pos.x = playerPos.x;
        pos.y = playerPos.y + 2;
        pos.z = playerPos.z - 8;

        transform.position = pos;
    }
}
