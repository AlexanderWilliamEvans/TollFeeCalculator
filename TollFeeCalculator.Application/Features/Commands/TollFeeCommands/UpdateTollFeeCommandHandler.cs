using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Application.Features.Commands.TollFeeCommands
{
	internal sealed class UpdateTollFeeCommandHandler : ICommandHandler<UpdateTollFeeCommand, TollFee>
	{
		public UpdateTollFeeCommandHandler()
		{
			
		}
		public Task<TollFee> Handle(UpdateTollFeeCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
