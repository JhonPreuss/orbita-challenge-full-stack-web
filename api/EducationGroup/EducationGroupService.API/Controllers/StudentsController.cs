using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationGroupService.API.Controllers
{
    //[Route("students")]//actions para chamar as aplications 
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly IApplicationServicesStudents _applicationServicesStudents;

        public StudentsController(IApplicationServicesStudents ApplicationServicesStudents)
        {
            _applicationServicesStudents = ApplicationServicesStudents;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicesStudents.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicesStudents.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] StudentsDto studentsDto)
        {
            try
            {
                if(studentsDto == null)
                    return NotFound();
                _applicationServicesStudents.Add(studentsDto);
                return Ok("Aluno cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] StudentsDto studentsDto)
        {
            try
            {
                if (studentsDto == null)
                    return NotFound();
                _applicationServicesStudents.Update(studentsDto);
                return Ok("Aluno atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] StudentsDto studentsDto)
        {
            //melhorar a tratativa
            try
            {
                if (studentsDto == null)
                    return NotFound();
                _applicationServicesStudents.Remove(studentsDto);
                return Ok("Aluno removido com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
