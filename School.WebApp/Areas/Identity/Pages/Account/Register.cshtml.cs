using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using School.Data.Entities;

namespace School.WebApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
             RoleManager<IdentityRole> roleManager )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            //_roleList = _roleManager.Roles.Select(d => new SelectListItem { Value = d.Id, Text = d.Name });
        }

        public  IEnumerable<SelectListItem> RoleList;



        [BindProperty]
        public InputModel Input { get; set; }

         public string RoleName { get; set; }
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "البريد الإلكتروني")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "يجب أن يكون {0} على الأقل {2} والحد الأقصى {1} من الأحرف.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "كلمة السر ")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "تأكيد كلمة السر")]
            [Compare("Password", ErrorMessage = "كلمة المرور وتأكيد كلمة المرور  غير متطابقتين.")]
            public string ConfirmPassword { get; set; }
            public string? RoleId { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!await _roleManager.RoleExistsAsync("MangerRole"))
            {
                await _roleManager.CreateAsync(new IdentityRole("AdminRole"));
                await _roleManager.CreateAsync(new IdentityRole("TeacherRole"));
                await _roleManager.CreateAsync(new IdentityRole("StudentRole"));
                await _roleManager.CreateAsync(new IdentityRole("SubMangerRole"));
                await _roleManager.CreateAsync(new IdentityRole("MangerRole"));
            }
            ReturnUrl = returnUrl;
            RoleList = _roleManager.Roles.Select(d => new SelectListItem { Value = d.Id, Text = d.Name });

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                if (User.IsInRole("MangerRole"))
                {
                    foreach (var item in _roleManager.Roles)
                    {
                        if (item.Id == Input.RoleId)
                        {
                            RoleName = item.Name;
                        }
                    }
                }


                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (User.IsInRole("MangerRole"))
                {
                    var RoleResult = await _userManager.AddToRoleAsync(user, RoleName);
                }
                else
                {
                    var RoleResult = await _userManager.AddToRoleAsync(user, "StudentRole");

                }


                if (result.Succeeded )
                {
                    
                 


                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
