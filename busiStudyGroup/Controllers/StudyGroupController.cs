using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using busiStudyGroup.Models;


namespace busiStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {

            //create student objects (add data to controller)
            List<StudyGroup> myStudents = new List<StudyGroup>
            {
                new StudyGroup
                {
                    StudentNum = "u24704785",
                    Name = "Busiswe",
                    Surname = "Paul",
                    Email = "u24704785@tuks.co.za"
                },

                new StudyGroup
                {
                    StudentNum = "u24722490",
                    Name = "Nyiko",
                    Surname = "Mbhalati",
                    Email = "u24722490@tuks.co.za"
                },

                new StudyGroup
                {
                    StudentNum = "u24641342",
                    Name = "Michael",
                    Surname = "Neto",
                    Email = "u24641342@tuks.co.za"
                },

                new StudyGroup
                {
                    StudentNum = "u22675524",
                    Name = "Thato",
                    Surname = "Modise",
                    Email = "u22675524@tuks.co.za"
                },

                new StudyGroup
                {
                    StudentNum = "u24687945",
                    Name = "Naledi",
                    Surname = "Nkwana",
                    Email = "u24687945@tuks.co.za"
                },




            };
            return View(myStudents);//link to view
        }
    }
}