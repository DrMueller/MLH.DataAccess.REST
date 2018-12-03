using System;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Dtos
{
    public class IndividualDto : DtoBase<long?>
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}