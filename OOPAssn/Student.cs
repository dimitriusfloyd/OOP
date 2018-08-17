using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssn
{   

    public class Student
    {
        
        public string Name { get; set; }
        //maybe have the ability to choose level
        public Level Level { get; set; }//6th, 7th, 8th(or 1,2,3)  //assigns coresponding teacher  //determines test difficulty
        //maybe have the ability to choose subject //then have the take test method within the subject //ex. return student.math.score
        Subject Subject { get; set; }//list of subjects maybe
        //teacher takes student.math.store : student.math.grade : 
        //reportcard takes student.math.grade : student.math.mark : presents subject/mark for each student student.reportcard
        //students have the ability to take test()
        int TakeTest()
        {
            //generate random number that gets stored scoreCount
            //each time they take test it gets added to testCount
            //when student takes test they get a random number back as score
            //teacher takes score(s) and returns grade
            //reportcard takes grade and returns mark and coresponding subject
            return Score;
        }
        //private methods will be those that do the math and if statement to produce mark
        int Score { get; set; }
        int Grade { get; set; }
        ReportCard ReportCard { get; set ;}
        //each student has a count of number of test taken in given subject
        //each student has a count of the scores they get on a test in given subject

        //score is the number the student makes on the test
        //test scores get averaged to produce grade
        //grade gets converted to string mark
    }
}
