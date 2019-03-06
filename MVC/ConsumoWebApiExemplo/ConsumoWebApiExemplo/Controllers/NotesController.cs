﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using ConsumoWebApiExemplo.Models.DTO;

namespace ConsumoWebApiExemplo.Controllers
{
    public class NotesController : Controller
    {
        HttpClient client = new HttpClient();

        public NotesController()
        {
            client.BaseAddress = new Uri("http://www.deveup.com.br/notas/api/notes");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: Notes
        public ActionResult Index()
        {
            List<Note> notes = new List<Note>();
            HttpResponseMessage response = client.GetAsync("/api/notes").Result;
            if (response.IsSuccessStatusCode)
            {
                notes = response.Content.ReadAsAsync<List<Note>>().Result;
            }
            return View(notes);
        }

        // GET: Notes/Details/5
        public ActionResult Details(int id)
        {
            HttpResponseMessage responde = client.GetAsync($"/api/notes/{id}").Result;
            Note note = responde.Content.ReadAsAsync<Note>().Result;
            if (note != null)
            {
                return View(note);
            }
            else
            {
               return HttpNotFound();
            }
        }

        // GET: Notes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        public ActionResult Create(Note note)
        {
            try
            {
                HttpResponseMessage response = client.PostAsJsonAsync<Note>("api/notes", note).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Error while creating note";
                    return View();
                }
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Notes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Notes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
