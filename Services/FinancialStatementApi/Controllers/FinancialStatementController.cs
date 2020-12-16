﻿using FinancialStatement.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialStatementApi.Controllers
{
    [Route("/api/v1/financialstatement")]
    public class FinancialStatementController : Controller
    {

        private readonly IFinancialStatementBusinessLogic _businessLogic;

        public FinancialStatementController(IFinancialStatementBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("find/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var financial = await _businessLogic.GetById(id);
            if (financial == null)
                return NotFound();
            return Ok(financial);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var financials = await _businessLogic.GetByUserId(userId);
            if (financials == null)
            {
                return NotFound();

            }
            return Ok(financials);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var financial = await _businessLogic.GetById(id);
            if (financial == null)
            {
                return NotFound();
            }
            await _businessLogic.Delete(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FinancialStatementDto financialStatementDto)
        {
           
            await _businessLogic.Create(financialStatementDto);
            return StatusCode(201);

        }

        [HttpPut("id")]
        public async Task<IActionResult> Update([FromBody] FinancialStatementDto financialStatementDto)
        {
            var financial = await _businessLogic.GetById(financialStatementDto.Id);
            if (financial == null)
            {
                return NotFound();
            }
            await _businessLogic.Update(financialStatementDto);
            return NoContent();
        }

    }
}