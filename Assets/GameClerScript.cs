using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClerScript : MonoBehaviour
{
    public GameObject gameClerText;
    public static bool isClear;
    // Start is
    //called before the first frame update
    void Start()
    {
        isClear = false;   
    }
    private void OnTriggerEnter(Collider other)
    {
        gameClerText.SetActive(true);
        isClear = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
