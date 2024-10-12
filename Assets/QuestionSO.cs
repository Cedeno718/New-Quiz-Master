using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quiz Questions", menuName = "New Question")]
public class QuestionSO : ScriptableObject {
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here.";
    public string GetQuestion()
    {
        return question;
    }
}