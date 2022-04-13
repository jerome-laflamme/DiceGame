namespace Form;

public class Questions
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool IsCorrect { get; set; }
    public int Score { get; set; }

    public Questions(string question, string answer, bool isCorrect, int score)
    {
        Question = question;
        Answer = answer;
        IsCorrect = isCorrect;
        Score = score;
    }
 
    public string GetQuestion()
    {
        string[] question = new string[]
        {
            "Quelle est la plus grande ville de Cuba ?",
            "Quelle est la plus grande ville du Canada ?",
            "Quelle est la capitale du Maroc ?",
            "Quel est le pays d'hexagone ?",
            "Quel est le plus grand continent du monde ?",
            "Quelle est la langue officielle du Brésil ?",
            "Quelle est la monnaie de l'Argentine ?",
            "Quelles sont les trois villes les plus propres au monde ?",
            "Quelle est la ville appelée 'ville ocre' ?",
            "Quelle est la capitale de Seychelles ?"
        };

        return question[0];
    }
    public string GetAnswer()
    {
        string[] answers = new string[]
        {
            "La Havane",
            "Toronto",
            "Rabat",
            "France",
            "Asie",
            "Portugais",
            "Peso argentin",
            "Calgary (Canada), Wellington (Nouvelle-Zélande) et Ifrane (Maroc)",
            "Marrakech",
            "Victoria"
        };

        return answers[0];
    }
    
    
}