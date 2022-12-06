using CarritoCompras.Core.Interfaces;
using CarritoCompras.Core.Models.DTOs;
using CarritoCompras.Mapper;
using CarritoCompras.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Core.Business
{
    public class CartBusiness : ICartsBusiness
    {
        public readonly IUnitOfWork _unitOfWork;

        public CartBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Insert(CartDto dto) => await _unitOfWork.CartsRepository.Insert(CartMapper.toCart(dto));
    }
}
