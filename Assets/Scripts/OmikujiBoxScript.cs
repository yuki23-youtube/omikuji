using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmikujiBoxScript : MonoBehaviour
{
    private string goodLuck = "大吉";
    private string badLuck = "凶";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string NotifyOmikujiResult()
    {
        int selectedLuck = Random.Range(0, 2);
        if (selectedLuck == 0)
            return badLuck;
        return goodLuck;
    }
}
