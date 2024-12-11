using System.Drawing;
using System.Runtime.CompilerServices;

public class Student {
    string name;
    string lastName; 
    DateTime birthDate; 
    int totalPoints;
    string[,] grades = {{"Sv", "Ma", "Fy", "Pe"}, {"", "", "", ""}}; 

    public Student(string name, string lastName, DateTime birthDate) {
        this.name = name;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }


    public int TotalPoints {
        get { return totalPoints; }
    }


    public string FullName {
        get { return $"{name} {lastName}"; }
    }


    private int convertToPoints(string grade) {
        int points = 0; 

        switch (grade) {
            case "A": 
                points = 250;
                break;
            case "B":
                points = 200;
                break;
            case "C":
                points = 150;
                break;
            case "D":
                points = 100;
                break;
            case "E":
                points = 50;
                break;
            case "F": 
                points = 0;
                break;
        }

        return points; 
    }


    public int getAvarge() {
        return totalPoints / 4; 
    }


    public int calculateTotalPoints() {
        for (int col = 0; col < 4; col++) {
            string grade = grades[1, col];
            totalPoints += convertToPoints(grade); 
        }

        return totalPoints;
    }


    public bool isAdult() {
        DateTime CurrentDate = DateTime.Now;
        return CurrentDate.Year - birthDate.Year >= 18;
    }


    public void SetGrade(string subject, string grade) {
        for (int col = 0; col < 4; col++) {
            if (grades[0, col] == subject) {
                grades[1, col] = grade;
            }
        }
    }
}