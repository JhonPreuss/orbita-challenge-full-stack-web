using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace EducationGroupService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private readonly IApplicationServicesCourses _applicationServicesCourses;

        public CoursesController(IApplicationServicesCourses ApplicationServicesCourses)
        {
            _applicationServicesCourses = ApplicationServicesCourses;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicesCourses.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicesCourses.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CoursesDto coursesDto)
        {
            try
            {
                if (coursesDto == null)
                    return NotFound();
                _applicationServicesCourses.Add(coursesDto);
                return Ok("Curso cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CoursesDto coursesDto)
        {
            try
            {
                if (coursesDto == null)
                    return NotFound();
                _applicationServicesCourses.Update(coursesDto);
                return Ok("Curso atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CoursesDto coursesDto)
        {
            //melhorar a tratativa
            try
            {
                if (coursesDto == null)
                    return NotFound();
                _applicationServicesCourses.Remove(coursesDto);
                return Ok("Curso removido com sucesso!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
