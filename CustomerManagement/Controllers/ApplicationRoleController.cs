using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    //[Authorize]
    public class ApplicationRoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public ApplicationRoleController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            List<ApplicationRoleViewModel> model = new List<ApplicationRoleViewModel>();
            model = roleManager.Roles.Select(r => new ApplicationRoleViewModel
            {
                RoleName = r.Name,
                Id = r.Id,
                Description = r.Description
            }).ToList();
            return View(model);
        }

        public IActionResult CreateOrEdit(string id)
        {
            ApplicationRoleViewModel model = new ApplicationRoleViewModel();
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationRole applicationRole = roleManager.Roles.FirstOrDefault(r => r.Id == id);
                if (applicationRole != null)
                {
                    model.Id = applicationRole.Id;
                    model.RoleName = applicationRole.Name;
                    model.Description = applicationRole.Description;
                }
            }
            return PartialView("_Create", model);
        }

        public async Task<IActionResult> CreateOrEditRole(string id, ApplicationRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Create", model);
            }

            ApplicationRole applicationRole = !String.IsNullOrEmpty(id) ? roleManager.Roles.FirstOrDefault(r => r.Id == id) :
              new ApplicationRole
              {
                  CreatedDate = DateTime.UtcNow
              };
            applicationRole.Name = model.RoleName;
            applicationRole.Description = model.Description;
            applicationRole.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            IdentityResult roleRuslt = !String.IsNullOrEmpty(id) ? await roleManager.UpdateAsync(applicationRole)
                                                : await roleManager.CreateAsync(applicationRole);
            if (roleRuslt.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            ApplicationRoleViewModel model = new ApplicationRoleViewModel();
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationRole applicationRole = await roleManager.FindByIdAsync(id);
                if (applicationRole != null)
                {
                    model.Id = applicationRole.Id;
                    model.RoleName = applicationRole.Name;
                    model.Description = applicationRole.Description;
                }
            }
            return PartialView("_DeleteRole", model);
        }

        public async Task<IActionResult> DeleteApplicationRole(ApplicationRoleViewModel model)
        {
            if (model != null)
            {
                ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.Id);
                if (applicationRole != null)
                {
                    IdentityResult roleRuslt = roleManager.DeleteAsync(applicationRole).Result;
                    if (roleRuslt.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return PartialView("_DeleteRole", model);
        }
    }
}