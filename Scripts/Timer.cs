using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timetoCompleteQuestion=30f;
 [SerializeField] float timetoShowAnswer=10f;
 public bool isAnsweringQuestion=false;
 float time=0f;
 public float filFraction;
 public float loadNextQuestion;
   
    void Update()
    {
        SetTimer();
    }
    public void CanCelTimer(){
        time=0;
     
            }
    void SetTimer()
    {
        time-=Time.deltaTime;
        if(isAnsweringQuestion)
        {

            if(time>0)
            {
filFraction=time/timetoCompleteQuestion;
            }
            else
            {
                time=timetoShowAnswer;
                isAnsweringQuestion=false;
            }
        }
        else
        {if(time>0)
            {
filFraction=time/timetoCompleteQuestion;
            }
            else
            {
                time=timetoCompleteQuestion;
                isAnsweringQuestion=true;
                loadNextQuestion=true;
            }
        }
    }
}
