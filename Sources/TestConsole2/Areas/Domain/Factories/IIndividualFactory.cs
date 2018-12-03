using System;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Factories
{
    public interface IIndividualFactory
    {
        Individual Create(string firstName, string lastName, DateTime birthdate, long? id = null);
    }
}