﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LGAConnectPortal.Models
{
    public class StudentLoginResult
    {
        public bool IsSuccess { get; set; }

        public int ID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Password { get; set; }

        public string GradeLevel { get; set; }

        public string SectionName { get; set; }

        public string Fullname { get; set; }

        public byte[] StudentProfile { get; set; }
    }
}
