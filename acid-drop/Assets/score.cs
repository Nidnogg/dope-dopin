using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public float scoreamount;
    public float pointincrease;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoreamount = 0f;
        pointincrease = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (int)scoreamount+"";
        scoreamount += pointincrease *Time.deltaTime; 
    }
}
