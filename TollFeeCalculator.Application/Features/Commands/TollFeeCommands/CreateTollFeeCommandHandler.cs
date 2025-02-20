using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Application.Features.Commands.TollFeeCommands
{
	internal sealed class CreateTollFeeCommandHandler: ICommandHandler<CreateTollFeeCommand, TollFee>
	{
		public CreateTollFeeCommandHandler()
		{
			
		}

		public Task<TollFee> Handle(CreateTollFeeCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
