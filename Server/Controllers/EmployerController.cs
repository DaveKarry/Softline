using Microsoft.AspNetCore.Mvc;
using Softline.Models;
using Softline.Data;
using System.Collections.Generic;
using AutoMapper;
using Softline.DTO;
using Microsoft.AspNetCore.JsonPatch;

namespace Softline.Controllers
{
    //api/employer
    [Route("api/employers")]
    [ApiController]
    public class EmployerController : ControllerBase
    {

        private readonly IEmployerRepository _repository;
        public IMapper _mapper { get; }

        public EmployerController(IEmployerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/employers
        [HttpGet]
        public ActionResult <IEnumerable<EmployerReadDto>> GetAllEmployers()
        {
            var employers = _repository.GetEmployers();
            return Ok(_mapper.Map<IEnumerable<EmployerReadDto>>(employers));
        }

        //GET api/employers/{id}
        [HttpGet("{id}", Name="GetEmployerById")]
        public ActionResult <EmployerReadDto> GetEmployerById(int id)
        {
            var employer = _repository.GetEmployerById(id);
            if(employer != null){
                return Ok(_mapper.Map<EmployerReadDto>(employer));
            }
            return NotFound();
        }



        //POST api/employers/
        [HttpPost]
        public ActionResult<EmployerReadDto> CreateEmployer(EmployerCreateDto employerCreateDto)
        {
            var employerModel = _mapper.Map<Employer>(employerCreateDto);
            _repository.CreateEmployer(employerModel);
            _repository.Update();

            var employerReadDto = _mapper.Map<EmployerReadDto>(employerModel);
            return CreatedAtRoute(nameof(GetEmployerById), new {Id = employerReadDto.Id}, employerReadDto);
        }


        //PUT api/employers/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateEmployer(int id, EmployerUpdateDto employerUpdateDto){
            var employerModelFromRepository = _repository.GetEmployerById(id);
            if( employerModelFromRepository==null){
                return NotFound();
            }
            _mapper.Map(employerUpdateDto, employerModelFromRepository);
            _repository.UpdateEmployer(employerModelFromRepository);
            _repository.Update();
            return NoContent();
        }


        //PATCH api/employer/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialEmloyerUpdate(int id, JsonPatchDocument<EmployerUpdateDto> patchDoc){
            var employerModelFromRepository = _repository.GetEmployerById(id);
            if( employerModelFromRepository==null){
                return NotFound();
            }

            var employerToPatch = _mapper.Map<EmployerUpdateDto>(employerModelFromRepository);
            patchDoc.ApplyTo(employerToPatch, ModelState);
            if(!TryValidateModel(employerToPatch)){
                return ValidationProblem(ModelState);
            }

            _mapper.Map(employerToPatch, employerModelFromRepository);
            _repository.UpdateEmployer(employerModelFromRepository);
            _repository.Update();
            return NoContent();
        }

        //DELETE api/employers/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployer(int id){
            var employerModelFromRepository = _repository.GetEmployerById(id);
            if( employerModelFromRepository==null){
                return NotFound();
            }

            _repository.DeleteEmployer(employerModelFromRepository);
            _repository.Update();
            return NoContent();
        } 

    }
}
