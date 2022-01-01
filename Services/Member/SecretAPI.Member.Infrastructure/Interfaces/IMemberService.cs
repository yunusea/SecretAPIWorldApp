using SecretAPI.Member.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAPI.Member.Infrastructure.Interfaces
{
    public interface IMemberService
    {
        public MemberDTO GetMemberById(int id);
    }
}
