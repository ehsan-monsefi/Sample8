using Domain.Contract;
using Domain.Entittes;
using Infrastracture.DAL;
using System;
using System.Collections.Generic;

namespace Domain.ApplicationService
{
    public class TblUserFacade : ITblUserFacade
    {
        ITblUserRepository repository;
        public TblUserFacade()
        {
            repository = new TblUserRepository();
        }
        public int AddTblUser(TblUser tblUser)
        {
            return repository.AddTblUser(tblUser);
        }

        public List<TblUser> GetTblUsers()
        {
            return repository.GetTblUsers();
        }
    }
}
