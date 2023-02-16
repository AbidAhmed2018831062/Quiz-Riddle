using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Questions", menuName = "Questions")]
public class Questions : ScriptableObject {
    [TextArea(2,6)]
    [SerializeField] string questions="Enter your question here";
    [SerializeField] string[] answer=new string[4];
    [SerializeField] int correctAnswer;

    public string getQuestion()
    {
        return questions;
    }
    public int getCorrectIndex()
    {
        return correctAnswer;
    }
        public string getCorrectAnswer(int i)
    {
        return answer[i];
    }
}

