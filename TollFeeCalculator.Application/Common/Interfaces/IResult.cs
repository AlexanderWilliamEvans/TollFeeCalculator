using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Application.Common.Interfaces
{
	public interface IResult
	{
		string[] Errors { get; init; }

		bool Succeeded { get; init; }
	}

	public interface IResult<out T> : IResult
	{
		T? Data { get; }
	}
}
