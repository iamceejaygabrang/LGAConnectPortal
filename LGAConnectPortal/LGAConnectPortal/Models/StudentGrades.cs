﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LGAConnectPortal.Models
{
    public class StudentGrades
    {
        public int ID { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public double WrittenWork1 { get; set; }

        public double WrittenWork2 { get; set; }

        public double WrittenWork3 { get; set; }

        public double WrittenWork4 { get; set; }

        public double WrittenWork5 { get; set; }

        public double WrittenWork6 { get; set; }

        public double WrittenWork7 { get; set; }

        public double WrittenWork8 { get; set; }

        public double WrittenWork9 { get; set; }

        public double WrittenWork10 { get; set; }

        public double WrittenWorkTotal { get; set; }

        public double WrittenWorkPercentage { get; set; }

        public double TaskPeformance1 { get; set; }

        public double TaskPeformance2 { get; set; }

        public double TaskPeformance3 { get; set; }

        public double TaskPeformance4 { get; set; }

        public double TaskPeformance5 { get; set; }

        public double TaskPeformance6 { get; set; }

        public double TaskPeformance7 { get; set; }

        public double TaskPeformance8 { get; set; }

        public double TaskPeformance9 { get; set; }

        public double TaskPeformance10 { get; set; }

        public double TaskPeformanceTotal { get; set; }

        public double TaskPeformancePercentage { get; set; }

        public double InitialGrade { get; set; }

        public double QuarterlyGrade { get; set; }

        public int SubjectName { get; set; }

        public string SchoolYearStart { get; set; }

        public string Grade_Level { get; set; }

        public string SectionName { get; set; }

        public int SaveasDraft { get; set; }

        public int SaveDraft { get; set; }

        public int GradingPeriod { get; set; }

        //public string TeacherFirstname { get; set; }

        //public string TeacherLastname { get; set; }

       // private string fullname;

        //public string Fullname
        //{
        //    get { return $"{TeacherFirstname} {TeacherLastname}"; }
        //    set { fullname = value; }

        //}
    }
}
