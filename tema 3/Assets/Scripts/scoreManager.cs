using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{ 
    public static scoreManager Instance;
    public TMP_Text scoreText;

    int score = 0;

    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
