using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssn
{
    class ReportCard
    {
        string[] reportCard { Subject, Mark}
        class Subject { get; set;
        string Mark { get; set; }
        //has ability to get grade from student in each subject and return mark in each subject and coresponding subject name
              if (Student.Score< 100 && Student.Score >= 90)
            {
                return "A";
            }
            if (Student.Score< 90 && Student.Score >= 80 )
            {
                return "B";
            }
            if (Student.Score<80 && Student.Score >= 70)
            {
                return "C";
            }
            if (Student.Score< 70 && Student.Score >= 60 )
            {
                return "D";
            }
            if (Student.Score< 60 && Student.Score >= 0)
            {
                return "F";
            }

            return "N/A";
    }
}
