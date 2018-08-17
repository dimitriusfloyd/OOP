using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssn
{   //teacher class inheriting from faculty and employee classes but has individual fields/properties
    class Teacher : Faculty
    {
        public Level Level { get; set; }
        public Subject Subject { get; set; }
        //teacher have ability to take score from test and make grade in their given subject
        int GetGrade()
        {
            //Student.score for each test in given subject / number of test taken in given subject
            return
        }
        //when student takes test() they get a score back 
        //teacher averages scores and returns grade
        //report card returns the subject and mark produced from grade
        string GetGrade(Student.Score) //encapsulation demonstrated by not exposing the method to calculate the score  //
        {
          //average of all of a particular students scores in a particular subject
        }
    }
}
