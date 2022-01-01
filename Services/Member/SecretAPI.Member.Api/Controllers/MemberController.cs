using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecretAPI.Member.Infrastructure.Interfaces;
using SecretAPI.Member.Models.DTOs;

namespace SecretAPI.Member.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MemberController(IMemberService MemberService)
        {
            memberService = MemberService;
        }

        [HttpGet("{id}")]
        public MemberDTO Member(int id)
        {
            return memberService.GetMemberById(id);
        }
    }
}
