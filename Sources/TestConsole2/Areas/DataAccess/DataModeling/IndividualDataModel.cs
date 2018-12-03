using System;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.DataModeling
{
    public class IndividualDataModel : DataModelBase<long?>
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}