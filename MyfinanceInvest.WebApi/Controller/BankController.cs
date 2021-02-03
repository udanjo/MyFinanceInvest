using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyfinanceInvest.WebApi.Request;
using MyFinanceInvest.Domain.Entities;
using MyFinanceInvest.Response;
using MyFinanceInvest.Service.Interfaces;
using System.Collections.Generic;

namespace MyFinanceInvest.Controller
{
    [Route("api/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService _BankService;
        private readonly IMapper _mapper;

        public BankController(IBankService bankService,
                              IMapper mapper)
        {
            _BankService = bankService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bank = _BankService.Get(id).Result;
            var response = _mapper.Map<BankResponse>(bank);
            return Ok(response);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var banks = _BankService.All().Result;
            var response = _mapper.Map<List<BankResponse>>(banks);
            return Ok(response);
        }

        [HttpGet("find")]
        public IActionResult GetFind([FromBody] BankRequest request)
        {
            var banks = _BankService.All().Result;
            var response = _mapper.Map<List<BankResponse>>(banks);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Save([FromBody] BankRequest request)
        {
            var info = _mapper.Map<BankInfo>(request);
            var success = _BankService.Save(info).Result;

            return Ok(success);
        }

        [HttpPut]
        public IActionResult Update([FromBody] BankRequest request)
        {
            var info = _mapper.Map<BankInfo>(request);
            var success = _BankService.Update(info).Result;

            return Ok(success);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _BankService.Delete(id).Result;
            return Ok(success);
        }
    }
}