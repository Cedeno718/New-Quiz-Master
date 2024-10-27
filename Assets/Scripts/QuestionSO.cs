using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quiz Questions", menuName = "New Question")]
public class QuestionSO : ScriptableObject {
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here.";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int CorrectAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
    public int GetCorrectAnswerIndex()
    {
        return CorrectAnswerIndex;
    }
    
}