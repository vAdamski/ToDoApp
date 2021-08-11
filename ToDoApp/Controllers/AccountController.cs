using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp
{
    [Route("account/")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("getCurrentUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var user = await _userManager.GetUserAsync(User);

            if(user == null)
            {
                return Unauthorized();
            }

            return Ok(user);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]UserRegisterViewModel userRegisterViewModel)
        {
            var newUser = new ApplicationUser
            {
                Email = userRegisterViewModel.Email,
                UserName = userRegisterViewModel.Email,
                FirstName = userRegisterViewModel.FirstName,
                LastName = userRegisterViewModel.LastName
            };

            var result = await _userManager.CreateAsync(newUser, userRegisterViewModel.Password);
            if(result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

                await _userManager.ConfirmEmailAsync(newUser, token);

                return Ok();
            }

            return NotFound();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginViewModel userLoginViewModel)
        {
            var foundUser = await _userManager.FindByEmailAsync(userLoginViewModel.Email);
            if(foundUser == null)
            {
                return NotFound();
            }

            var result = await _signInManager.PasswordSignInAsync(foundUser, userLoginViewModel.Password, true, false);
            if(result.Succeeded)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpGet]
        [Route("logOut")]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}
