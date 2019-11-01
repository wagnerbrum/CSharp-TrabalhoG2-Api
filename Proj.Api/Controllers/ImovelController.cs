﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Proj.Domain.Entities;
using Proj.Repository.Interfaces;

namespace Proj.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private IImovelRepository repository;

        public ImovelController(IImovelRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Imovel>> Get()
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetAll()
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Imovel> Get(int id)
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetByID(id)
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Imovel entity)
        {
            repository.Create(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Imovel entity)
        {
            repository.Update(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}
