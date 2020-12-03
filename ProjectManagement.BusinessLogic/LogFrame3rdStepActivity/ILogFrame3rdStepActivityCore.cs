﻿using ProjectManagement.ViewModel;

namespace ProjectManagement.BusinessLogic
{
    public interface ILogFrame3rdStepActivityCore
    {
        DbResponse AddorUpdate(LogFrame3rdStepModel model);
        DbResponse<LogFrame3rdStepModel> Get(int projectId);
    }
}