﻿using LGAConnectPortal.Helpers;
using LGAConnectPortal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectPortal.Gateway
{
    public class FinalGradeGateway
    {
        static string BaseUrl = "http://cegagabrang-001-site1.btempurl.com/api/lga/finalgradestudent";

        public async Task<IEnumerable<FinalGrade>> GetStudentGradesByID(int ID)
        {
            try
            {
                string url = $"{BaseUrl}/get_all/{ID}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<FinalGrade>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<FinalGrade>();
            }
        }
    }
}