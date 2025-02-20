﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Application.Features.Commands.TollFeeCommands
{
	public sealed record CreateTollFeeCommand(TollFee tollFee) : ICommand<TollFee>
	{
	}
}
