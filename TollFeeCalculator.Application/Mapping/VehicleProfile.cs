using AutoMapper;
using TollFeeCalculator.Application.Dtos;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Application.Mapping
{
	public class VehicleProfile: Profile
	{
		public VehicleProfile() {
			CreateMap<Vehicle, AddVehicleDto>();
			CreateMap<Vehicle, UpdateVehicleDto>();
		}
	}
}
