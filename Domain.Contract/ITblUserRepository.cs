using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ITblUserRepository
    {
        List<TblUser> GetTblUsers();
        int AddTblUser(TblUser tblUser);
    }
}
