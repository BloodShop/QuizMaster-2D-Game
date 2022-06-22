using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionSO", menuName = "Question SO")]

public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)] // Set the min and max lines area
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField]int correctAnswerIndex;

    public string GetQuestion() {
        return question;
    }

    public int GetCorrectAnswerIndex() {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index) {
        return answers[index];
    }
}

// public class Test 
// {
//     QuestionSO questionSO;

//     void TestA() {
//         string questionText = questionSO.GetQuestion();
//     }
// }