﻿using Core.Application.Users.UserDtos;
using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.TimeSheets
{
    public interface ITimeSheetRepository
    {
        Task<PayloadCustom<TimeSheet>> GetTimeSheets();
        Task<PayloadCustom<Project>> GetProjects();
        void AddTimeSheet(TimeSheet timeSheet);
    }
}
