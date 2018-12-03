using System;
using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.Domain.Factories
{
    public interface IIndividualFactory
    {
        Individual Create(string firstName, string lastName, DateTime birthdate, string id = null);
    }
}