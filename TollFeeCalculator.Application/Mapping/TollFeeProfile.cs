using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Application.Dtos;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Application.Mapping
{
	public class TollFeeProfile: Profile
	{
		public TollFeeProfile() {
			CreateMap<TollFee, AddTollFeeDto>();
			CreateMap<TollFee, UpdateTollFeeDto>();
		}
	}
}
