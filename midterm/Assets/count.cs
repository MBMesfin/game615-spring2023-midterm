using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class count : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        TimerOn = true;
        TimeLeft = 30;

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0 && score < 4)
            {
                TimeLeft -= Time.deltaTime;
                TimerText.text = TimeLeft.ToString();
            }
            else if (TimeLeft > 0 && score == 4)
            {
                ScoreText.text = "You Win!";
            }
            else
            {
                TimeLeft = 0;
                TimerText.text = TimeLeft.ToString();
                TimerOn = false;
                ScoreText.text = "You lost,sadly...";

            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pin"))
        {
            Destroy(other.gameObject);
            ScoreText.text = score.ToString();
            score++;

        }


    }
}
