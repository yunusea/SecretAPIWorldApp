using SecretAPI.Member.Infrastructure.Interfaces;
using SecretAPI.Member.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAPI.Member.Services.Services
{
    public class MemberService : IMemberService
    {
        public MemberDTO GetMemberById(int id)
        {
            return new MemberDTO()
            {
                Id = id,
                FirstName = "Yunus Emre",
                LastName = "AKBULUT"
            };
        }
    }
}
