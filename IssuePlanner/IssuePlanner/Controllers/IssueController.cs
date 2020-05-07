using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using IssuePlanner.Models;
using Newtonsoft.Json;
using System.IO;

namespace IssuePlanner.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        public async Task<ActionResult> Index()
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var shouldPrioritize = new RepositoryIssueRequest
            {
                Assignee = "*",
                Milestone = "none",
                Filter = IssueFilter.All
            };
            var issues = await client.Issue.GetAllForRepository("idcf-boat-house", "boat-house", shouldPrioritize);
            List<GithubIssueModel> issList = new List<GithubIssueModel>();
            foreach (var item in issues)
            {
                issList.Add(new GithubIssueModel
                {
                    Assignee = item.Assignee == null ? "No Assignee" : item.Assignee.Name,
                    IssueId = $"#{item.Number}",
                    IssueTitle = item.Title
                });
            }

            IssueViewModel vm = new IssueViewModel();
            vm.AllIssue = issList;
            vm.LeftTable = issList.Select(i => i.IssueId).ToList();
            vm.RightTable = new List<string>();
            vm.JsonString = JsonConvert.SerializeObject(vm);

            //本地模拟数据
            //string mockString = System.IO.File.ReadAllText("mock-issue.json");
            //var vm = JsonConvert.DeserializeObject<IssueViewModel>(mockString);
            //vm.JsonString = mockString;

           
            return View(vm);
        }

        // GET: Issue/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Issue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issue/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Issue/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Issue/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Issue/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Issue/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}