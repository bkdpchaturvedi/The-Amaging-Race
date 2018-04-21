using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.AspNet.Identity.EntityFramework;
using NUS.TheAmagingRace.BusinessModels;
using NUS.TheAmagingRace.DAL;
using NUS.TheAmagingRace.DAL.UnitOfWork;

namespace NUS.TheAmagingRace.BAL
{
    public class MemberBAL : IMemberBAL
    {
        private readonly UOW _unitOfWork;
        public MemberBAL()
        {
            _unitOfWork = new UOW();

            // need to reset mapper. otherwise, mapper already initialised error            

           


        }

        public void AddAdministrator(TARUserViewModel user)
        {
            // TARUser aRUser= SaveUser(user);
            TARUser aRUser = Mapper.Map<TARUser>(user);
            AddUserToRole(aRUser, "Admin");
        }

        private TARUser SaveUser(TARUserViewModel user)
        {
            using (var scope = new TransactionScope())
            {
                TARUser aUser = Mapper.Map<TARUser>(user);
                aUser.CreatedAt = DateTime.Now;
                _unitOfWork.UserRepository.Insert(aUser);
                _unitOfWork.Save();
                return aUser;
               
            }

        }

        private void AddUserToRole(TARUser tARUser,string RoleName)
        {
            using (var scope = new TransactionScope())
            {
                IdentityUserRole userRole = new IdentityUserRole();
                userRole.RoleId = _unitOfWork.RoleRepository.Roles.First(m => m.Name == RoleName)?.Id;
                userRole.UserId = tARUser.Id;
                tARUser.Roles.Add(userRole);
                _unitOfWork.Save();
                scope.Complete();
            }
        }
        private void RemoveUserToRole(TARUser tARUser, string RoleName)
        {
            using (var scope = new TransactionScope())
            {
                IdentityUserRole userRole = new IdentityUserRole();
                userRole.RoleId = _unitOfWork.RoleRepository.Roles.First(m => m.Name == RoleName)?.Id;
                userRole.UserId = tARUser.Id;
                tARUser.Roles.Remove(userRole);
                _unitOfWork.Save();
                scope.Complete();
            }
        }
        public void AddMember(TARUserViewModel user)
        {
            TARUser aRUser = Mapper.Map<TARUser>(user);
            AddUserToRole(aRUser, "Member");
        }

        public void AddStaff(TARUserViewModel user)
        {
            TARUser aRUser = Mapper.Map<TARUser>(user);
            AddUserToRole(aRUser, "Staff");
        }

        public void DeleteUser(TARUserViewModel user)
        {
            using (var scope = new TransactionScope())
            {
                TARUser aRUser = Mapper.Map<TARUser>(user);
                _unitOfWork.UserRepository.Delete(aRUser);
                _unitOfWork.Save();
                scope.Complete();
            }
        }

        public IEnumerable<TARUserViewModel> GetAllMember()
        {
            var Users = _unitOfWork.UserRepository.GetMany(m => m.Roles.Any(n => n.RoleId == _unitOfWork.RoleRepository.Roles.First(v => !(v.Name.Equals("Staff") || v.Name.Equals("Admin")))?.Id)).ToList();
            var UserViewModels = Mapper.Map<List<TARUser>, List<TARUserViewModel>>(Users);
            return UserViewModels;

        }

        public IEnumerable<TARUserViewModel> GetAllStaff()
        {
            var Users = _unitOfWork.UserRepository.GetMany(m=>m.Roles.Any(n=>n.RoleId ==_unitOfWork.RoleRepository.Roles.First(v=>v.Name=="Staff")?.Id)).ToList();
            var UserViewModels = Mapper.Map<List<TARUser>, List<TARUserViewModel>>(Users);
            return UserViewModels;
        }

        public IEnumerable<TARUserViewModel> GetAllTARAdministrators()
        {
            var Users = _unitOfWork.UserRepository.GetMany(m => m.Roles.Any(n => n.RoleId == _unitOfWork.RoleRepository.Roles.First(v => v.Name == "Admin")?.Id)).ToList();
            var UserViewModels = Mapper.Map<List<TARUser>, List<TARUserViewModel>>(Users);
            return UserViewModels;
        }

        public void MoveMembertoAdmin(TARUserViewModel user)
        {
           TARUser tARUser= Mapper.Map<TARUserViewModel,TARUser>(user);
            AddUserToRole(tARUser, "Admin");
         }

        public void MoveMembertoStaff(TARUserViewModel user)
        {
            TARUser tARUser = Mapper.Map<TARUserViewModel, TARUser>(user);
            AddUserToRole(tARUser, "Staff");
        }

        public void RemoveMemberasAdmin(TARUserViewModel user)
        {
            TARUser tARUser = Mapper.Map<TARUserViewModel, TARUser>(user);
            RemoveUserToRole(tARUser, "Admin");
        }

        public void RemoveMemberasStaff(TARUserViewModel user)
        {
            TARUser tARUser = Mapper.Map<TARUserViewModel, TARUser>(user);
            RemoveUserToRole(tARUser, "Staff");
        }

        public void UpdateUser(TARUserViewModel user)
        {
            TARUser tARUser = Mapper.Map<TARUserViewModel, TARUser>(user);
            using (var scope=new TransactionScope())
            {
                _unitOfWork.UserRepository.Update(tARUser);
                _unitOfWork.Save();
                scope.Complete();
            }
        }
    }
}
