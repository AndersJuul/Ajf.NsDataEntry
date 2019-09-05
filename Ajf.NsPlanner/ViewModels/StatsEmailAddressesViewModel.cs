﻿using Ajf.NsPlanner.Application.Abstractions;
using Ajf.NsPlanner.Domain.Abstractions;
using Ajf.NsPlanner.Domain.Entities;
using Ajf.NsPlanner.Domain.Queries;
using Ajf.NsPlanner.UI.Abstractions;

namespace Ajf.NsPlanner.UI.ViewModels
{
    public class StatsEmailAddressesViewModel : StatsBaseViewModel<IQuery<SimpleStatTable>, SimpleStatTable>,
        IStatsEmailAddressesViewModel
    {
        public StatsEmailAddressesViewModel(IDispatcher dispatcher) : base(dispatcher)
        {
        }

        public override string Title => SelectedPeriod == null
            ? "Ingen periode valgt"
            : "Emailstat for " + SelectedPeriod.DateRange;

        protected override IQuery<SimpleStatTable> GetQuery(Assignment[] currentAssignments)
        {
            return new EmailAddressesQuery(currentAssignments);
        }
    }
}