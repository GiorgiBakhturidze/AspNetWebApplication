using Microsoft.AspNetCore.Mvc;                                                            
using System;                                                                              
using System.Collections.Generic;                                                          
using System.Linq;                                                                         
using System.Threading.Tasks;                                                              
using Data.ApplicationModels;                                                              
using Microsoft.AspNetCore.Identity;                                                       
using Microsoft.AspNetCore.Authorization;                                                  
                                                                                           
namespace MVC.Controllers                                                                  
{                                                                                          
    [AllowAnonymous]                                                                       
    public class AccountController : Controller                                            
    {                                                                                      
        private SignInManager<ApplicationUser> _signInManager;                    
        private UserManager<ApplicationUser> _userManager;                        
                                                                                           
        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {                                                                                  
            _signInManager = signInManager;                                                
            _userManager = userManager;                                                    
        }                                                                                  
                                                                                           
        [HttpGet]                                                                          
        public IActionResult Login()                                                       
        {                                                                                  
            return View(new LoginInputModel());                                      
        }                                                                                  
                                                                                           
        [HttpPost]                                                                         
        public IActionResult Login(LoginInputModel inputedModel)                           
        {                                                                                  
            return View();                                                                 
        }                                                                                  
                                                                                           
        [HttpGet]                                                                          
        public ActionResult Register()                                                     
        {                                                                                  
            return View(new RegisterInputModel());                                 
        }                                                                                  
                                                                                           
        [HttpPost]                                                                         
        public async Task<IActionResult> Register(RegisterInputModel inputedModel)         
        {                                                                                  
            if (ModelState.IsValid && inputedModel.Password == inputedModel.ConfirmPassword)
            {                                                                              
                ApplicationUser newUser = new ApplicationUser { Email = inputedModel.Email, EmailConfirmed = true, PhoneNumberConfirmed = true, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0 };
                var result = await _userManager.CreateAsync(newUser, inputedModel.Password);
                if (result.Succeeded)                                                      
                {                                                                          
                    await _signInManager.SignInAsync(newUser, isPersistent: false);        
                }                                                                          
            }                                                                              
            return View();                                                                 
        }                                                                                  
    }                                                                                      
}                                                                                          
                                                                                           