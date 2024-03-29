﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LGAConnectPortal.Models
{
    public class StudentGradesPerSubject
    {
        public string SubjectName { get; set; }

        //public string FacultyName { get; set; }

        public double FirstGrading { get; set; }

        public bool IsFirstGradingSubmitted { get; set; }

        public double SecondGrading { get; set; }

        public bool IsSecondGradingSubmitted { get; set; }

        public double ThirdGrading { get; set; }

        public bool IsThirdGradingSubmitted { get; set; }

        public double FourthGrading { get; set; }

        public bool IsFourthGradingSubmitted { get; set; }

        public double FinalGrade { get; set; }

        public double Average { get; set; }

        public string TeacherFirstname { get; set; }

        public string TeacherLastname { get; set; }

        private string facultyname;

        public string FacultyName
        {
            get { return $"{TeacherFirstname} {TeacherLastname}"; }
            set { facultyname = value; }

        }

        public bool NoGradesAvailable 
        { 
            get => !IsFirstGradingSubmitted && !IsSecondGradingSubmitted && !IsThirdGradingSubmitted && !IsFourthGradingSubmitted;
        }

        public bool FinalGradeAvaiable 
        { 
            get => IsFirstGradingSubmitted && IsSecondGradingSubmitted && IsThirdGradingSubmitted && IsFourthGradingSubmitted;
        }
    }
}
