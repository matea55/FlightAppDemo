using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.UserRepository;
using System.Security.Cryptography;
using System.Text;
using UserManager.Dtos;

namespace UserManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private IUserRepository _userRepository;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }


        [HttpPost("register")]
        public async Task<ActionResult> Register(UserDto userDto)
        {
            bool RegistrationOk = RegisterUser(userDto);
            if (RegistrationOk)
            {
                return Ok(userDto.Username);
            }
            else
            {
                return BadRequest();
            }
            
        }

        private bool RegisterUser(UserDto userDto)
        {
            string Hash = MakeHash(userDto.Password);
            if(CheckIfUserExists(userDto.Username)) {
                return false;           
            }
            else
            {
                User user = new User
                {
                    Username = userDto.Username,
                    Email = userDto.Email,
                    PasswordSha = Hash
                };
                _userRepository.InsertUser(user);
                _userRepository.Save();
                return true;
            }
        }

        private bool CheckIfUserExists(string username)
        {
            if(_userRepository.GetUserByUsername(username) != null)
            {
                return true;
            }
            else { return false; }
        }

        private string MakeHash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                
                byte[] bytes = Encoding.UTF8.GetBytes(password);

               
                byte[] hashBytes = sha256.ComputeHash(bytes);

                
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}