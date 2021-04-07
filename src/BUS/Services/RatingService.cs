using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class RatingService
        : BaseService<RatingVM, Rating>,
        IRatingService
    {
        private IRatingDAO _ratingDao;

        public RatingService(IRatingDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _ratingDao = dao;
        }

        public RatingVM Add(int productId, string userId, RatingVM newObject)
        {
            if (productId == 0 || userId == null || userId == "") return null;
            var ratingObj = _mapper.Map<Rating>(newObject);
            ratingObj.ProductId = productId;
            ratingObj.UserId = userId;
            return _mapper.Map<RatingVM>(this._ratingDao.AddItem(ratingObj));
        }

        public ICollection<RatingVM> GetByProduct(int productId)
        {
            return _mapList<RatingVM, Rating>(_ratingDao.GetByProduct(productId));
        }

        public ICollection<RatingVM> GetByUser(string userId)
        {
            return _mapList<RatingVM, Rating>(_ratingDao.GetByUser(userId));
        }
    }
}