using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastracture.DAL
{
    public class TblUserRepository : ITblUserRepository
    {
        SmContext context;
        public TblUserRepository()
        {
            context = new SmContext();
        }
        public int AddTblUser(TblUser tblUser)
        {
            context.TblUsers.Add(tblUser);
            context.SaveChanges();
            return tblUser.Id;
        }

        public List<TblUser> GetTblUsers()
        {
            return context.TblUsers.ToList();
        }
    }
}
    