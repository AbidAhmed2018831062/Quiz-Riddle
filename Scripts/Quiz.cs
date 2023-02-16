using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI text;
  [SerializeField] Questions ques;
  [SerializeField] Sprite correctAnswerSprite;
  [SerializeField] GameObject[] answer;
    void Start()
    {
      DisplayQuestion();
    }
    public void OnButtonSelected(int index){
      if(index==ques.getCorrectIndex())
      {
        text.text="Correct Answer";
        Image buttonImage=answer[index].GetComponent<Image>();
        buttonImage.sprite=correctAnswerSprite;
      }
      else
      {
        text.text="Sorry your answer is wrong. The correct answer is: "+ques.getCorrectAnswer(ques.getCorrectIndex());
        Image buttonImage=answer[ques.getCorrectIndex()].GetComponent<Image>();
        buttonImage.sprite=correctAnswerSprite;
      }
      SetState(false);
    }
    void DisplayQuestion()
    {
        text.text=ques.getQuestion();
        for(int i=0;i<answer.Length;i++)
        {
          TextMeshProUGUI button=answer[i].GetComponentInChildren<TextMeshProUGUI>();
          button.text=ques.getCorrectAnswer(i);
        }
    }
   void SetNextQuestion()
   {
      DisplayQuestion();
      SetState(true);
   }
    void SetState(bool state){
       for(int i=0;i<answer.Length;i++)
        {
         Button button=answer[i].GetComponent<Button>();
         button.interactable=state;
        }
    }
    void Update()
    {
        
    }
}
