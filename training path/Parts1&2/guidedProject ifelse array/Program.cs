using System;
using System.Runtime.InteropServices;

// initialize variables - graded assignments 
int currentAssignments = 5;

//stores exam scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
//column headers
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    string currentStudentLetterGrade ="";

    if (currentStudent == "Sophia")
        studentScores =sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores=andrewScores;
    else if (currentStudent == "Emma")
        studentScores=emmaScores;
    else if (currentStudent == "Logan")
        studentScores=loganScores;
    else if (currentStudent =="Becky")
        studentScores=beckyScores;
    else if (currentStudent =="Chris")
        studentScores=chrisScores;
    else if (currentStudent =="Eric")
        studentScores=ericScores;
    else if (currentStudent =="Gregor")
        studentScores=gregorScores;
    else
        continue;
    
    //set sum of scored assignments to 0
    int sumExamScores = 0;

    //initialize or reset calculated extra credit
    decimal sumExtraScores = 0.0m;

    //initialize or reset calculated average of exam scores
    decimal studentExamScore =0;

    //initialize or reset calculated average of exam scores and extra credit
    decimal studentFinalScore =0;

    //initialize or reset calculated extra credit average
    decimal studentExtraScore = 0;
    //initialize or reset counter for number of assignments and extra assignments
    int gradedAssignments =0;
    int extraAssignments =0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= currentAssignments)
        {
            //add exam score to the sum
            sumExamScores+= score;
        }
        else
        {
            //score is extra credit. adds bonus points equal to 10% of score
            sumExtraScores+= (decimal)score/10;

            //finds and stores extra credit to calculate average
            studentExtraScore+=score;
            extraAssignments++;            
        }
    }

    //calculates average of extra credit scores
    if(extraAssignments >0)
            studentExtraScore = studentExtraScore/extraAssignments;

    //score without extra credit
    studentExamScore = (decimal)sumExamScores/currentAssignments;

    //score with extra credit
    studentFinalScore = (decimal)(sumExamScores+sumExtraScores)/currentAssignments;

    //if-else structure to get current student letter grade
    if (studentFinalScore >= 97)
        currentStudentLetterGrade = "A+";
    else if (studentFinalScore >= 93)
        currentStudentLetterGrade = "A";
    else if (studentFinalScore >= 90)
        currentStudentLetterGrade = "A-";
    else if (studentFinalScore >= 87)
        currentStudentLetterGrade = "B+";
    else if (studentFinalScore >= 83)
        currentStudentLetterGrade = "B";
    else if (studentFinalScore >= 80)
        currentStudentLetterGrade = "B-";
    else if (studentFinalScore >= 77)
        currentStudentLetterGrade = "C+";
    else if (studentFinalScore >= 73)
        currentStudentLetterGrade = "C";
    else if (studentFinalScore >= 70)
        currentStudentLetterGrade = "C-";
    else if (studentFinalScore >= 67)
        currentStudentLetterGrade = "D+";
    else if (studentFinalScore >= 63)
        currentStudentLetterGrade = "D";
    else if (studentFinalScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    
    Console.WriteLine($"{currentStudent}:\t\t{studentExamScore}\t\t{studentFinalScore}\t{currentStudentLetterGrade}\t{studentExtraScore} ({studentFinalScore-studentExamScore} pts)");
}




Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
