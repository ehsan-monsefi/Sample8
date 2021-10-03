using Domain.Entittes;
using System;
using System.Collections.Generic;

namespace Domain.Contract
{
    public interface ITblUserFacade
    {
        List<TblUser> GetTblUsers();
        int AddTblUser(TblUser tblUser);
    }
}
