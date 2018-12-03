using System;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Factories.Implementation
{
    public class IndividualFactory : IIndividualFactory
    {
        public Individual Create(string firstName, string lastName, DateTime birthdate, long? id = null)
        {
            return new Individual(
                id,
                firstName,
                lastName,
                birthdate);
        }
    }
}