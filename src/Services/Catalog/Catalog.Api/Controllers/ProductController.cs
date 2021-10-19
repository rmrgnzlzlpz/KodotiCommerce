using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.Queries;
using Catalog.Services.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductQueryService _productQueryService;
        private readonly IMediator _mediator;

        public ProductController(
            ILogger<ProductController> logger, 
            IProductQueryService productQueryService,
            IMediator mediator
        )
        {
            _logger = logger;
            _productQueryService = productQueryService;
            _mediator = mediator;
        }

        /// <summary>
        /// Obtener todos los productos
        /// </summary>
        /// <param name="page">Página actual</param>
        /// <param name="take">Cantidad de registros</param>
        /// <param name="ids">Ids controlados</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;
            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }

        /// <summary>
        /// Consultar producto por id
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<ProductDto> GetAll(int id)
        {
            return await _productQueryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}
